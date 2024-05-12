
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C968
{
    public partial class ModifyProduct : Form
    {

        BindingList<Part> modifyPartsAdded = new BindingList<Part>();

        

        // Now the list needs to be initialized so you can use it elsewhere


        Form1 MainWindow = (Form1)Application.OpenForms["form1"];
        public static string selectedProduct;

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            
            ModifyProductScreenLoad(product);
        }

        private void ModifyProductScreenLoad(Product currentProduct)
        {
            // Set the text fields with the current product details
            ProductModifyIDtxt.Text = currentProduct.ProductID.ToString();
            ProductModifyNametxt.Text = currentProduct.Name;
            ProductModifyInventorytxt.Text = currentProduct.Inventory.ToString();
            ProductModifyPricetxt.Text = currentProduct.Price.ToString();
            ProductModifyMintx.Text = currentProduct.Min.ToString();
            ProductModifyMaxtx.Text = currentProduct.Max.ToString();

            // Create a binding source for all available parts
            var Part2 = new BindingSource();
            Part2.DataSource = Inventory.AllParts;
            dataGridView2a.DataSource = Part2;

            // Clear the modifyPartsAdded list to start fresh
            modifyPartsAdded.Clear();

            // Add associated parts from the current product to the modifyPartsAdded list
            foreach (Part part in currentProduct.AssociatedParts.ToList())
            {
                modifyPartsAdded.Add(part);
            }

            // Create a binding source for the modified associated parts
            var AssociatedParts = new BindingSource();
            AssociatedParts.DataSource = modifyPartsAdded;
            dataGridView2b.DataSource = AssociatedParts;
        }

        // Save modifications
        private void ModifyProductSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Null Error Handling for data fields
                if (string.IsNullOrEmpty(ProductModifyIDtxt.Text) ||
                    string.IsNullOrEmpty(ProductModifyNametxt.Text) ||
                    string.IsNullOrEmpty(ProductModifyInventorytxt.Text) ||
                    string.IsNullOrEmpty(ProductModifyPricetxt.Text) ||
                    string.IsNullOrEmpty(ProductModifyMintx.Text) ||
                    string.IsNullOrEmpty(ProductModifyMaxtx.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                if (dataGridView2b.Rows.Count > 0)

                {

                    if (int.Parse(ProductModifyMaxtx.Text) < int.Parse(ProductModifyMintx.Text))
                    {
                        MessageBox.Show("Minimum cannot be greater than the Maximum.");
                        return;
                    }
                    // Inventory Error Handling --Min
                    if (int.Parse(ProductModifyInventorytxt.Text) < int.Parse(ProductModifyMintx.Text))
                    {
                        MessageBox.Show("Inventory cannot be less than the Minimum.");
                        return;
                    }
                    //Inventory Error Handling ---Max
                    if (int.Parse(ProductModifyInventorytxt.Text) > int.Parse(ProductModifyMaxtx.Text))
                    {
                        MessageBox.Show("Inventory cannot be greater than the Maximum.");
                        return;
                    }

                    if (int.Parse(ProductModifyInventorytxt.Text) < int.Parse(ProductModifyMaxtx.Text))
                    {
                        MessageBox.Show("Max cannot be greater than the Inventory.");
                        return;
                    }
                    // Find the existing product by its ID
                    int productID = int.Parse(ProductModifyIDtxt.Text);
                    Product existingProduct = Inventory.LookupProduct(productID);
                    
                    Product product = new Product(
                        int.Parse(ProductModifyIDtxt.Text),
                        ProductModifyNametxt.Text,
                        int.Parse(ProductModifyInventorytxt.Text),
                        decimal.Parse(ProductModifyPricetxt.Text),
                        int.Parse(ProductModifyMaxtx.Text),
                        int.Parse(ProductModifyMintx.Text)
                    );

                    Inventory.UpdateProduct(productID, product);

                    // Assuming you have a method to update associated parts
                    foreach (Part part in modifyPartsAdded)
                    {
                        product.AddAssociatedPart(part);
                    }



                    this.Close();
                    MainWindow.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Add associatedparts
        private void ProductPartModify_Click(object sender, EventArgs e)
       
        {
            // Check if a row is selected in dataGridView2a
            if (dataGridView2a.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2a.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                // Add the selected part to modifyPartsAdded
                modifyPartsAdded.Add(selectedPart);

                // Refresh dataGridView2b to reflect the updated list
                dataGridView2b.Refresh();

                // Display the contents of modifyPartsAdded
            }
            else
            {
                // Handle the case when no row is selected (optional)
                MessageBox.Show("Please select a part from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Search for parts

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCriteria = ProductModifySearch.Text;
                dataGridView2a.ClearSelection();

                // Search by part ID (if input is a valid integer)
                if (int.TryParse(searchCriteria, out int partID))
                {
                    try
                    {
                        Part returnedData = Inventory.LookupPart(partID);
                        Debug.WriteLine($"{returnedData.PartID}");
                        foreach (DataGridViewRow row in dataGridView2a.Rows)
                        {
                            // 0 is the column index for part ID
                            if (row.Cells[0].Value.ToString().Equals(Convert.ToString(returnedData.PartID)))
                            {
                                row.Selected = true;
                                return;
                            }
                        }
                        MessageBox.Show("Part could not be found!");
                    }
                    catch (FormatException) { MessageBox.Show("Part could not be found!"); }
                }
                else
                {
                    // Search by part name (case-insensitive comparison)
                    foreach (DataGridViewRow row in dataGridView2a.Rows)
                    {
                        // 1 is the column index for part name
                        if (row.Cells[1].Value.ToString().IndexOf(searchCriteria, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                    MessageBox.Show("No matching parts found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Delete assocated parts

        private void DeleteModify_Click(object sender, EventArgs e)
        {
            if (dataGridView2b.SelectedRows.Count > 0)
            {

                if (dataGridView2b.SelectedRows.Count > 0)
                {
                    // Get the selected row index
                    int selectedRowIndex = dataGridView2b.SelectedRows[0].Index;
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Remove the row from the DataGridView
                        dataGridView2b.Rows.RemoveAt(selectedRowIndex);
                    }
                }

                else
                {
                    MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

       

        //Close Form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow.Show();
        }

        // Error handling for datafield data types
        private void ProductModifyInventorytxt_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(ProductModifyInventorytxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for inventory.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductModifyInventorytxt.Clear();
            }
        }



        private void ProductModifyPricetxt_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(ProductModifyPricetxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductModifyPricetxt.Clear();
            }
        }

        
        private void ProductModifyMintx_TextChanged(object sender, EventArgs e)
        
        {
            if (!int.TryParse(ProductModifyMintx.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Min.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductModifyMintx.Clear();
            }
        }

        private void ProductModifyMaxtx_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(ProductModifyMaxtx.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductModifyMaxtx.Clear();
            }
        }

       
    }
}        
        


    