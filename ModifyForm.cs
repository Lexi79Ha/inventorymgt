
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C968
{
    public partial class ModifyForm : Form
    {
        
        Form1 MainWindow = (Form1)Application.OpenForms["form1"];
        public static string selectedPart;
        public ModifyForm(InHousePart inhousePart)
        {
            InitializeComponent();
            //Autofill data fields for selected part
            PartModifyIDtxt.Text = inhousePart.PartID.ToString();
            PartModifyNametxt.Text = inhousePart.Name;
            PartsModifyInventorytxt.Text = inhousePart.Inventory.ToString();
            PartsModifyPricetxt.Text = inhousePart.Price.ToString();
            PartsModifyMaxtxt.Text = inhousePart.Max.ToString();
            PartsModifyMintxt.Text = inhousePart.Min.ToString();
            PartsModifyMachineIDtxt.Text = inhousePart.MachineID.ToString();

            PartModifyInhouse.Checked = true;

        }

        public ModifyForm(OutsourcedPart outsourcedPart)
        {
            InitializeComponent();
            //Autofill data fields for selected part
            PartModifyIDtxt.Text = outsourcedPart.PartID.ToString();
            PartModifyNametxt.Text = outsourcedPart.Name;
            PartsModifyInventorytxt.Text = outsourcedPart.Inventory.ToString();
            PartsModifyPricetxt.Text = outsourcedPart.Price.ToString();
            PartsModifyMaxtxt.Text = outsourcedPart.Max.ToString();
            PartsModifyMintxt.Text = outsourcedPart.Min.ToString();
            PartsModifyMachineIDtxt.Text = outsourcedPart.CompanyName;

            PartModify.Checked = true;
        }

        // Radio Button Label Handling - Inhouse
        private void PartModifyInhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (PartModifyInhouse.Checked)
                {
                    PartModifyMachineID.Text = "Machine ID";                 

                }
            }
        }
        // Radio Button Label Handling - Outsourced
        private void PartModify_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (PartModify.Checked)
                {
                    PartModifyMachineID.Text = "Company Name";


                    PartsModifyMachineIDtxt.Name = "PartModifyComanyNmtxt";
                }
                
            }
        }


        private void PartModifySave_Click(object sender, EventArgs e)
        {
            try
            {
                // Error handling for Null data fields
                if (string.IsNullOrEmpty(PartModifyNametxt.Text) ||
                    string.IsNullOrEmpty(PartsModifyInventorytxt.Text) ||
                    string.IsNullOrEmpty(PartsModifyPricetxt.Text) ||
                    string.IsNullOrEmpty(PartsModifyMaxtxt.Text) ||
                    string.IsNullOrEmpty(PartsModifyMintxt.Text) ||
                    string.IsNullOrEmpty(PartsModifyMachineIDtxt.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Conditioning for Max/Min
                if (int.Parse(PartsModifyMaxtxt.Text) < int.Parse(PartsModifyMintxt.Text))
                {
                    MessageBox.Show("Minimum cannot be greater than the Maximum.");
                    return;
                }
                // Inventory Error Handling --Min
                if (int.Parse(PartsModifyInventorytxt.Text) < int.Parse(PartsModifyMintxt.Text))
                {
                    MessageBox.Show("Inventory cannot be less than the Minimum.");
                    return;
                }
                //Inventory Error Handling ---Max
                if (int.Parse(PartsModifyInventorytxt.Text) > int.Parse(PartsModifyMaxtxt.Text))
                {
                    MessageBox.Show("Inventory cannot be greater than the Maximum.");
                    return;
                }

                if (int.Parse(PartsModifyMaxtxt.Text) > int.Parse(PartsModifyInventorytxt.Text))
                {
                    MessageBox.Show("Maximum cannot be greater than the Inventory.");
                    return;
                }
                // Get the original part ID
                int originalPartID = int.Parse(PartModifyIDtxt.Text);

                // Create updated data
                if (PartModifyInhouse.Checked)
                {
                    InHousePart inHouse = new InHousePart(originalPartID, PartModifyNametxt.Text, int.Parse(PartsModifyInventorytxt.Text), decimal.Parse(PartsModifyPricetxt.Text), int.Parse(PartsModifyMaxtxt.Text), int.Parse(PartsModifyMintxt.Text), int.Parse(PartsModifyMachineIDtxt.Text));
                    Inventory.UpdatePart(originalPartID, inHouse);
                }
                else
                {
                    OutsourcedPart outsourced = new OutsourcedPart(originalPartID, PartModifyNametxt.Text, int.Parse(PartsModifyInventorytxt.Text), decimal.Parse(PartsModifyPricetxt.Text), int.Parse(PartsModifyMaxtxt.Text), int.Parse(PartsModifyMintxt.Text), PartsModifyMachineIDtxt.Text);
                    Inventory.UpdatePart(originalPartID, outsourced);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Error Handling for data types
        private void PartsModifyInventorytxt_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PartsModifyInventorytxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for inventory.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartsModifyInventorytxt.Clear(); // Clear the textbox
            }
        }

        private void PartsModifyPricetxt_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(PartsModifyPricetxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartsModifyPricetxt.Clear(); // Clear the textbox
            }
        }

        private void PartsModifyMaxtxt_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PartsModifyMaxtxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartsModifyMaxtxt.Clear(); // Clear the textbox
            }
        }

        private void PartsModifyMintxt_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PartsModifyMintxt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartsModifyMintxt.Clear(); // Clear the textbox
            }
        }

        private void PartMachineIDtxt_TextChanged(object sender, EventArgs e)
        {
            if (PartModifyInhouse.Checked)
                if (!int.TryParse(PartsModifyMachineIDtxt.Text, out _))
                {
                    MessageBox.Show("Please enter a valid integer value for MachineID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PartsModifyMachineIDtxt.Clear();
                }
        }
        //Cancel Button
        private void PartModifyCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainWindow.Show();
        }

        private void PartsModifyMachineIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
