
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C968
{
    public partial class AddProductForm : Form
    {
        BindingList<Part> partsAdded = new BindingList<Part>();

        Form1 MainWindow = (Form1)Application.OpenForms["form1"];
        private Product product;

        public AddProductForm()
        {
            InitializeComponent();
            product = new Product(); // Initialize with an empty product
            AddProductScreen();
        }

        public void AddProductScreen()
        {   // Parts table
            var Part2 = new BindingSource();
            Part2.DataSource = Inventory.AllParts;
            dataGridView1a.DataSource = Part2;
            // Associated table

            var Part3 = new BindingSource();
            Part3.DataSource = partsAdded; // Use the BindingList<Part> for associated parts
            dataGridView1b.DataSource = Part3;

        }


        //Save on click
        private void ProductSave_Click(object sender, EventArgs e)
        {
            // Error handling for Null datafields
            if (string.IsNullOrEmpty(ProductAddNametxt.Text) || string.IsNullOrEmpty(ProductAddInventorytxt.Text) || string.IsNullOrEmpty(ProductAddPricetxt.Text) || string.IsNullOrEmpty(ProductAddMaxtxt.Text) || string.IsNullOrEmpty(ProductAddMintxt.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            // Check if there are more than 0 rows in the DataGridView
            if (dataGridView1b.Rows.Count > 0)
            {
                // Exception Control 
                if (int.Parse(ProductAddMaxtxt.Text) < int.Parse(ProductAddMintxt.Text))
                {
                    MessageBox.Show("Minimum cannot be greater than the Maximum.");
                    return;
                }
               
                if (int.Parse(ProductAddMaxtxt.Text) > int.Parse(ProductAddInventorytxt.Text))
                {
                    MessageBox.Show("Max cannot be greater than the Inventory.");
                    return;
                }
                //Inventory Error Handling --Min
                if (int.Parse(ProductAddInventorytxt.Text) < int.Parse(ProductAddMintxt.Text))
                {
                    MessageBox.Show("Inventory cannot be less than the Minimum.");
                    return;
                }
                //Inventory Error Handling ---Max
                if (int.Parse(ProductAddInventorytxt.Text) > int.Parse(ProductAddMaxtxt.Text))
                {
                    MessageBox.Show("Inventory cannot be greater than the Maximum.");
                    return;
                }

                // Create a new product based on user input
                Product product = new Product(
                    (Inventory.Product.Count + 1),
                    ProductAddNametxt.Text,
                    int.Parse(ProductAddInventorytxt.Text),
                    decimal.Parse(ProductAddPricetxt.Text),
                    int.Parse(ProductAddMaxtxt.Text),
                    int.Parse(ProductAddMintxt.Text));

                // Add the new product to your Inventory
                Inventory.AddProduct(product);

                foreach (Part part in partsAdded)
                {
                    product.AddAssociatedPart(part);
                }

                this.Close();
                MainWindow.Show();

            }
            else
            {
                MessageBox.Show("Cannot save. Please select and add associated parts before submission.");
            }
        }


        private void ProductPartAdd_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected in dataGridView1a
            if (dataGridView1a.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1a.SelectedRows[0];

                Part selectedPart = (Part)selectedRow.DataBoundItem;

                partsAdded.Add(selectedPart);

                dataGridView1b.Refresh();
            }
            else
            {

            }
        }


        // Delete Associated Parts

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1b.SelectedRows.Count > 0)
            {
               
                int selectedRowIndex = dataGridView1b.SelectedRows[0].Index;


                DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
     
                    dataGridView1b.Rows.RemoveAt(selectedRowIndex);
                }
            }
            else
            {

                MessageBox.Show("Please select a row to delete.");
            }
        }



        //Search for parts 

        private void ProductAddSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCriteria = ProductAddSearchtxt.Text;
                dataGridView1a.ClearSelection();


                if (int.TryParse(searchCriteria, out int partID))
                {
                    try
                    {
                        Part returnedData = Inventory.LookupPart(partID);
                        Debug.WriteLine($"{returnedData.PartID}");
                        foreach (DataGridViewRow row in dataGridView1a.Rows)
                        {
                            
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
                    foreach (DataGridViewRow row in dataGridView1a.Rows)
                    {
                        
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

        // Error Handling for data fields


        private void ProductAddMintxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(ProductAddMintxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductAddMintxt.Clear();
            }
        }

        private void ProductAddMaxtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(ProductAddMaxtxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductAddMaxtxt.Clear();
            }
        }

        private void ProductAddPricetxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!decimal.TryParse(ProductAddPricetxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductAddPricetxt.Clear();
            }
        }

        private void ProductAddInventorytxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(ProductAddInventorytxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for inventory.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductAddInventorytxt.Clear();
            }
        }

        // Cancel
        private void ProductCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow.Show();
        }


    } 
}
