
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C968
{

    public partial class AddForm : Form
    {
        Form1 MainWindow = (Form1)Application.OpenForms["form1"];
        private Inventory inventory; // Declare an instance of the Inventory class
       
        public AddForm()
        {
            InitializeComponent();
            
        }

      
        // Radio Button Label Handling - Inhouse
        private void AddInhouse_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (AddInhouse.Checked)
                {
                    AddPartMachineID.Text = "Machine ID";

                }
            }
        }
        // Radio Button Label Handling - Outsourced
        private void AddOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (AddOutsourced.Checked)
                {
                    AddPartMachineID.Text = "Company Name";
                }
            }

        }


        // Error Handling for data types
        private void PartInventorytxt_TextChanged_1(object sender, EventArgs e)
        {
            // Validate input: Ensure only numeric values are entered
            if (!int.TryParse(PartInventorytxt.Text, out _))
            {
                
                MessageBox.Show("Please enter a valid numeric value for inventory.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartInventorytxt.Clear();
                
            }
        }

        private void PartPricetxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!decimal.TryParse(PartPricetxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartPricetxt.Clear(); // Clear the textbox
            }
        }

        private void PartMaxtxt_TextChanged_1(object sender, EventArgs e)
        {
            // Validate input: Ensure only numeric values are entered
            if (!int.TryParse(PartMaxtxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartMaxtxt.Clear(); // Clear the textbox
            }
        }

        private void PartMintxt_TextChanged_1(object sender, EventArgs e)
        {
            // Validate input: Ensure only numeric values are entered
            if (!int.TryParse(PartMintxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Min.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartMintxt.Clear(); // Clear the textbox
            }
        }

        private void PartMachineIDtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (AddInhouse.Checked)
                if (!int.TryParse(PartMachineIDtxt.Text, out _))
                {
                    MessageBox.Show("Please enter a valid integer value for MachineID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PartMachineIDtxt.Clear();
                }
        }

        private void PartAddSave_Click_1(object sender, EventArgs e)
        {
            
            // Null error handling
            if (string.IsNullOrEmpty(PartNametxt.Text) || string.IsNullOrEmpty(PartInventorytxt.Text) ||string.IsNullOrEmpty(PartPricetxt.Text) || string.IsNullOrEmpty(PartMaxtxt.Text) ||string.IsNullOrEmpty(PartMintxt.Text) || string.IsNullOrEmpty(PartMachineIDtxt.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            // Min/Max Error handling
            if (int.Parse(PartMaxtxt.Text) < int.Parse(PartMintxt.Text))
            {
                MessageBox.Show("Minimum cannot be greater than the Maximum.");
                return;
            }
            //Inventory Error Handling --Min
            if (int.Parse(PartInventorytxt.Text) < int.Parse(PartMintxt.Text))
            {
                MessageBox.Show("Inventory cannot be less than the Minimum.");
                return;
            }
            //Inventory Error Handling ---Max
            if (int.Parse(PartInventorytxt.Text) > int.Parse(PartMaxtxt.Text))
            {
                MessageBox.Show("Inventory cannot be greater than the Maximum.");
                return;
            }

            if (int.Parse(PartInventorytxt.Text) < int.Parse(PartMaxtxt.Text))
            {
                MessageBox.Show("Max cannot be greater than the Inventory.");
                return;
            }


            // Adding data to related class
            if (AddInhouse.Checked)
            {
                InHousePart inHouse = new InHousePart((Inventory.AllParts.Count + 1), PartNametxt.Text, int.Parse(PartInventorytxt.Text), decimal.Parse(PartPricetxt.Text), int.Parse(PartMaxtxt.Text), int.Parse(PartMintxt.Text), int.Parse(PartMachineIDtxt.Text));
                Inventory.AddPart(inHouse);
            }
            else
            {
                OutsourcedPart outsourced = new OutsourcedPart((Inventory.AllParts.Count + 1), PartNametxt.Text, int.Parse(PartInventorytxt.Text), decimal.Parse(PartPricetxt.Text), int.Parse(PartMaxtxt.Text), int.Parse(PartMintxt.Text), PartMachineIDtxt.Text);
                Inventory.AddPart(outsourced);
            }
            this.Close();
        }


        //Cancel button
        private void PartAddCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.Show();

        }

        private void PartIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartNametxt_TextChanged(object sender, EventArgs e)
        {

        }

  
        
    }
}
      

        

