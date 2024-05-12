using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public class Inventory
    {
        public static BindingList<Product> Product = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
  
        public static void AddProduct(Product product)
        {
            Product.Add(product);
        }

        public static void AddPart(Part newpart)
        {
            AllParts.Add(newpart);
        }
       

        public static bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product product in Product)
            {
                if (productID == product.ProductID)
                {
                    Product.Remove(product);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Removal failed.");
                    return success = false;
                }
            }
            return success;
        }


        public static Product LookupProduct(int ProductID)
        {
            Product product = Product.Single(c => c.ProductID == ProductID);
            return product;
        }
        public static void UpdateProduct(int ProductID, Product updatedProduct)
        {
            // Find the index of the product with the given ProductID
            int index = -1;
            for (int i = 0; i < Product.Count; i++)
            {
                if (Product[i].ProductID == ProductID)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                // Remove the existing product
                Product.RemoveAt(index);
                // Add the updated product
                Product.Add(updatedProduct);
                Console.WriteLine($"Product with ID {ProductID} updated successfully.");
            }
            else
            {
                Console.WriteLine($"Product with ID {ProductID} not found. Update failed.");
            }
        }

        public static bool DeletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }

        public static Part LookupPart(int partID)
        {
            Part item = AllParts.Single(c => c.PartID == partID);
            return item;
        }

        public static void UpdatePart(int PartID, Part part)
        {
            Part updatedData = LookupPart(PartID);
            DeletePart(updatedData);
            AddPart(part);
        }

    }
}


