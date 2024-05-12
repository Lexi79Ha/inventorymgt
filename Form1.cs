using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml.Linq;


namespace C968
{
    public partial class Form1 : Form
    {
        Product product = new Product();
       
        public Form1()
        {
            InitializeComponent();
            Form1ScreenLoad();                      

        }
     
        public void Form1ScreenLoad()
        {
            // Parts table
            var Part = new BindingSource();
            Part.DataSource = Inventory.AllParts;
            dataGridView1.DataSource = Part;
            //Product table
            var Product = new BindingSource();
            Product.DataSource = Inventory.Product;
            dataGridView2.DataSource = Product;

        }

        //Add Part
        private void PartAdd_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }


        //Modify Part
        private void PartModify_Click(object sender, EventArgs e)
        {
            // Check if a part is selected
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Please select a part to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Determine the type of the selected part and open the appropriate ModifyForm
            if (dataGridView1.CurrentRow.DataBoundItem.GetType() == typeof(C968.InHousePart))
            {
                InHousePart inHouse = (InHousePart)dataGridView1.CurrentRow.DataBoundItem;
                new ModifyForm(inHouse).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourced = (OutsourcedPart)dataGridView1.CurrentRow.DataBoundItem;
                new ModifyForm(outsourced).ShowDialog();
            }
        }

        //Add Product

        private void ProductAdd_Click(object sender, EventArgs e)
        {

            AddProductForm addproductForm = new AddProductForm();
            addproductForm.Show();
            this.Hide();
        }

        // Modify Product

        private void ProductModify_Click(object sender, EventArgs e)
        {
            // Check if a product is selected
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Please select a product to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Get the selected product from the DataGridView
            Product selectedProduct = (Product)dataGridView2.CurrentRow.DataBoundItem;

            // Open the ModifyProduct form with the selected product
            new ModifyProduct(selectedProduct).ShowDialog();
        }

        //Part Search
        private void PartSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCriteria = PartSearchtxt.Text;
                dataGridView1.ClearSelection();

                // Search by part ID (if input is a valid integer)
                if (int.TryParse(searchCriteria, out int partID))
                {
                    try
                    {
                        Part returnedData = Inventory.LookupPart(partID);
                        Debug.WriteLine($"{returnedData.PartID}");
                        foreach (DataGridViewRow row in dataGridView1.Rows)
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
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // 1 is the column index for part name
                        if (row.Cells[1].Value.ToString().IndexOf(searchCriteria, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                 
                    MessageBox.Show("Part could not be found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        //Product Search
        private void ProductSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCriteria = ProductSearchtxt.Text;
                dataGridView2.ClearSelection();

                // Search by product ID (if input is a valid integer)
                if (int.TryParse(searchCriteria, out int productID))
                {
                    try
                    {
                        Product returnedData = Inventory.LookupProduct(productID);
                        Debug.WriteLine($"{returnedData.ProductID}");
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            // 0 is the column index for product ID
                            if (row.Cells[0].Value.ToString().Equals(Convert.ToString(returnedData.ProductID)))
                            {
                                row.Selected = true;
                                return;
                            }
                        }
                        MessageBox.Show("Product could not be found!");
                    }
                    catch (FormatException) { MessageBox.Show("Product could not be found!"); }
                }
                else
                {
                    // Search by product name (case-insensitive comparison)
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        // 1 is the column index for product name
                        if (row.Cells[1].Value.ToString().IndexOf(searchCriteria, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                    MessageBox.Show("No matching products found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        // Delete Part
        private void PartDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                if (selectedRow == null)
                {
                    MessageBox.Show("No row selected. Please select a row to delete.");
                    return;
                }

                if (!int.TryParse(selectedRow.Cells["PartID"].Value?.ToString(), out int partID))
                {
                    MessageBox.Show("Invalid Part ID. Please select a valid row.");
                    return;
                }

                Part partToRemove = Inventory.LookupPart(partID);

                if (IsPartAssociated(partID))
                {
                    Product associatedProduct = GetAssociatedProduct(partID);
                    string productName = associatedProduct.Name;
                    MessageBox.Show($"This part is associated with {productName}. Please delete the associated product before removing the part.");
                    return;
                }

                var message = $"Are you sure you want to delete this part?\n\n";
                var title = "DELETION Event Detected!";
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Inventory.DeletePart(partToRemove);
                        MessageBox.Show("Part deleted successfully.");
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Nothing has been selected to delete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        // Function to check if a part is associated with any product
        private bool IsPartAssociated(int partID)
        {
            foreach (Product product in Inventory.Product)
            {
                if (product.LookupAssociatedPart(partID) != null)
                {
                    return true;
                }
            }
            return false;
        }

        // Function to retrieve the associated product
        private Product GetAssociatedProduct(int partID)
        {
            foreach (Product product in Inventory.Product)
            {
                if (product.LookupAssociatedPart(partID) != null)
                {
                    return product;
                }
            }
            return null;
        }

        // Delete Product and remove part from associatedparts list

        private void ProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView2.CurrentRow;

                if (selectedRow == null)
                {
                    MessageBox.Show("No row selected. Please select a row to delete.");
                    return;
                }

                if (!int.TryParse(selectedRow.Cells["ProductID"].Value?.ToString(), out int productID))
                {
                    MessageBox.Show("Invalid Product ID. Please select a valid row.");
                    return;
                }

                // Retrieve the product using the product ID
                Product productToRemove = Inventory.LookupProduct(productID);

                var message = $"Are you sure you want to delete this product?\n\n";
                var title = "DELETION Event Detected!";
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Remove the product using its ID
                        Inventory.RemoveProduct(productID);

                        // Remove associated parts
                        foreach (Part associatedPart in productToRemove.AssociatedParts.ToList())
                        {
                            productToRemove.RemoveAssociatedPart(associatedPart.PartID);
                        }

                      

                        MessageBox.Show("Product and associated parts deleted successfully.");
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Nothing has been selected to delete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Close Program
        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
