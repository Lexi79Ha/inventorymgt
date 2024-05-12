namespace C968
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddPartFormLabel = new System.Windows.Forms.Label();
            this.AddInhouse = new System.Windows.Forms.RadioButton();
            this.AddOutsourced = new System.Windows.Forms.RadioButton();
            this.PartAddID = new System.Windows.Forms.Label();
            this.PartAddName = new System.Windows.Forms.Label();
            this.PartAddInventory = new System.Windows.Forms.Label();
            this.AddPartPrice = new System.Windows.Forms.Label();
            this.AddPartMax = new System.Windows.Forms.Label();
            this.AddPartMin = new System.Windows.Forms.Label();
            this.AddPartMachineID = new System.Windows.Forms.Label();
            this.PartIDtxt = new System.Windows.Forms.TextBox();
            this.PartNametxt = new System.Windows.Forms.TextBox();
            this.PartInventorytxt = new System.Windows.Forms.TextBox();
            this.PartPricetxt = new System.Windows.Forms.TextBox();
            this.PartMachineIDtxt = new System.Windows.Forms.TextBox();
            this.PartMaxtxt = new System.Windows.Forms.TextBox();
            this.PartMintxt = new System.Windows.Forms.TextBox();
            this.PartAddSave = new System.Windows.Forms.Button();
            this.PartAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartFormLabel
            // 
            this.AddPartFormLabel.AutoSize = true;
            this.AddPartFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AddPartFormLabel.Location = new System.Drawing.Point(26, 25);
            this.AddPartFormLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddPartFormLabel.Name = "AddPartFormLabel";
            this.AddPartFormLabel.Size = new System.Drawing.Size(74, 20);
            this.AddPartFormLabel.TabIndex = 0;
            this.AddPartFormLabel.Text = "Add Part";
            // 
            // AddInhouse
            // 
            this.AddInhouse.AutoSize = true;
            this.AddInhouse.Location = new System.Drawing.Point(236, 29);
            this.AddInhouse.Margin = new System.Windows.Forms.Padding(6);
            this.AddInhouse.Name = "AddInhouse";
            this.AddInhouse.Size = new System.Drawing.Size(116, 29);
            this.AddInhouse.TabIndex = 1;
            this.AddInhouse.TabStop = true;
            this.AddInhouse.Text = "In-House";
            this.AddInhouse.UseVisualStyleBackColor = true;
            this.AddInhouse.CheckedChanged += new System.EventHandler(this.AddInhouse_CheckedChanged_1);
            // 
            // AddOutsourced
            // 
            this.AddOutsourced.AutoSize = true;
            this.AddOutsourced.Location = new System.Drawing.Point(384, 29);
            this.AddOutsourced.Margin = new System.Windows.Forms.Padding(6);
            this.AddOutsourced.Name = "AddOutsourced";
            this.AddOutsourced.Size = new System.Drawing.Size(141, 29);
            this.AddOutsourced.TabIndex = 2;
            this.AddOutsourced.TabStop = true;
            this.AddOutsourced.Text = "Outsourced";
            this.AddOutsourced.UseVisualStyleBackColor = true;
            this.AddOutsourced.CheckedChanged += new System.EventHandler(this.AddOutsourced_CheckedChanged);
            // 
            // PartAddID
            // 
            this.PartAddID.AutoSize = true;
            this.PartAddID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartAddID.Location = new System.Drawing.Point(194, 127);
            this.PartAddID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartAddID.Name = "PartAddID";
            this.PartAddID.Size = new System.Drawing.Size(20, 16);
            this.PartAddID.TabIndex = 3;
            this.PartAddID.Text = "ID";
            // 
            // PartAddName
            // 
            this.PartAddName.AutoSize = true;
            this.PartAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartAddName.Location = new System.Drawing.Point(146, 200);
            this.PartAddName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartAddName.Name = "PartAddName";
            this.PartAddName.Size = new System.Drawing.Size(44, 16);
            this.PartAddName.TabIndex = 4;
            this.PartAddName.Text = "Name";
            // 
            // PartAddInventory
            // 
            this.PartAddInventory.AutoSize = true;
            this.PartAddInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartAddInventory.Location = new System.Drawing.Point(112, 277);
            this.PartAddInventory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartAddInventory.Name = "PartAddInventory";
            this.PartAddInventory.Size = new System.Drawing.Size(61, 16);
            this.PartAddInventory.TabIndex = 5;
            this.PartAddInventory.Text = "Inventory";
            // 
            // AddPartPrice
            // 
            this.AddPartPrice.AutoSize = true;
            this.AddPartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AddPartPrice.Location = new System.Drawing.Point(96, 352);
            this.AddPartPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddPartPrice.Name = "AddPartPrice";
            this.AddPartPrice.Size = new System.Drawing.Size(69, 16);
            this.AddPartPrice.TabIndex = 6;
            this.AddPartPrice.Text = "Price/Cost";
            // 
            // AddPartMax
            // 
            this.AddPartMax.AutoSize = true;
            this.AddPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AddPartMax.Location = new System.Drawing.Point(170, 427);
            this.AddPartMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddPartMax.Name = "AddPartMax";
            this.AddPartMax.Size = new System.Drawing.Size(32, 16);
            this.AddPartMax.TabIndex = 7;
            this.AddPartMax.Text = "Max";
            // 
            // AddPartMin
            // 
            this.AddPartMin.AutoSize = true;
            this.AddPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AddPartMin.Location = new System.Drawing.Point(410, 427);
            this.AddPartMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddPartMin.Name = "AddPartMin";
            this.AddPartMin.Size = new System.Drawing.Size(28, 16);
            this.AddPartMin.TabIndex = 8;
            this.AddPartMin.Text = "Min";
            // 
            // AddPartMachineID
            // 
            this.AddPartMachineID.AutoSize = true;
            this.AddPartMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AddPartMachineID.Location = new System.Drawing.Point(24, 527);
            this.AddPartMachineID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddPartMachineID.Name = "AddPartMachineID";
            this.AddPartMachineID.Size = new System.Drawing.Size(74, 16);
            this.AddPartMachineID.TabIndex = 9;
            this.AddPartMachineID.Text = "Machine ID";
            // 
            // PartIDtxt
            // 
            this.PartIDtxt.Location = new System.Drawing.Point(248, 127);
            this.PartIDtxt.Margin = new System.Windows.Forms.Padding(6);
            this.PartIDtxt.Name = "PartIDtxt";
            this.PartIDtxt.ReadOnly = true;
            this.PartIDtxt.Size = new System.Drawing.Size(214, 31);
            this.PartIDtxt.TabIndex = 10;
            this.PartIDtxt.TextChanged += new System.EventHandler(this.PartIDtxt_TextChanged);
            // 
            // PartNametxt
            // 
            this.PartNametxt.Location = new System.Drawing.Point(248, 200);
            this.PartNametxt.Margin = new System.Windows.Forms.Padding(6);
            this.PartNametxt.Name = "PartNametxt";
            this.PartNametxt.Size = new System.Drawing.Size(214, 31);
            this.PartNametxt.TabIndex = 11;
            this.PartNametxt.TextChanged += new System.EventHandler(this.PartNametxt_TextChanged);
            // 
            // PartInventorytxt
            // 
            this.PartInventorytxt.Location = new System.Drawing.Point(248, 277);
            this.PartInventorytxt.Margin = new System.Windows.Forms.Padding(6);
            this.PartInventorytxt.Name = "PartInventorytxt";
            this.PartInventorytxt.Size = new System.Drawing.Size(214, 31);
            this.PartInventorytxt.TabIndex = 12;
            this.PartInventorytxt.TextChanged += new System.EventHandler(this.PartInventorytxt_TextChanged_1);
            // 
            // PartPricetxt
            // 
            this.PartPricetxt.Location = new System.Drawing.Point(246, 344);
            this.PartPricetxt.Margin = new System.Windows.Forms.Padding(6);
            this.PartPricetxt.Name = "PartPricetxt";
            this.PartPricetxt.Size = new System.Drawing.Size(214, 31);
            this.PartPricetxt.TabIndex = 13;
            this.PartPricetxt.TextChanged += new System.EventHandler(this.PartPricetxt_TextChanged_1);
            // 
            // PartMachineIDtxt
            // 
            this.PartMachineIDtxt.Location = new System.Drawing.Point(248, 519);
            this.PartMachineIDtxt.Margin = new System.Windows.Forms.Padding(6);
            this.PartMachineIDtxt.Name = "PartMachineIDtxt";
            this.PartMachineIDtxt.Size = new System.Drawing.Size(214, 31);
            this.PartMachineIDtxt.TabIndex = 14;
            this.PartMachineIDtxt.TextChanged += new System.EventHandler(this.PartMachineIDtxt_TextChanged_1);
            // 
            // PartMaxtxt
            // 
            this.PartMaxtxt.Location = new System.Drawing.Point(246, 425);
            this.PartMaxtxt.Margin = new System.Windows.Forms.Padding(6);
            this.PartMaxtxt.Name = "PartMaxtxt";
            this.PartMaxtxt.Size = new System.Drawing.Size(122, 31);
            this.PartMaxtxt.TabIndex = 15;
            this.PartMaxtxt.TextChanged += new System.EventHandler(this.PartMaxtxt_TextChanged_1);
            // 
            // PartMintxt
            // 
            this.PartMintxt.Location = new System.Drawing.Point(478, 425);
            this.PartMintxt.Margin = new System.Windows.Forms.Padding(6);
            this.PartMintxt.Name = "PartMintxt";
            this.PartMintxt.Size = new System.Drawing.Size(122, 31);
            this.PartMintxt.TabIndex = 16;
            this.PartMintxt.TextChanged += new System.EventHandler(this.PartMintxt_TextChanged_1);
            // 
            // PartAddSave
            // 
            this.PartAddSave.Location = new System.Drawing.Point(364, 594);
            this.PartAddSave.Margin = new System.Windows.Forms.Padding(6);
            this.PartAddSave.Name = "PartAddSave";
            this.PartAddSave.Size = new System.Drawing.Size(100, 67);
            this.PartAddSave.TabIndex = 17;
            this.PartAddSave.Text = "Save";
            this.PartAddSave.UseVisualStyleBackColor = true;
            this.PartAddSave.Click += new System.EventHandler(this.PartAddSave_Click_1);
            // 
            // PartAddCancel
            // 
            this.PartAddCancel.Location = new System.Drawing.Point(476, 594);
            this.PartAddCancel.Margin = new System.Windows.Forms.Padding(6);
            this.PartAddCancel.Name = "PartAddCancel";
            this.PartAddCancel.Size = new System.Drawing.Size(104, 67);
            this.PartAddCancel.TabIndex = 18;
            this.PartAddCancel.Text = "Cancel";
            this.PartAddCancel.UseVisualStyleBackColor = true;
            this.PartAddCancel.Click += new System.EventHandler(this.PartAddCancel_Click_1);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 713);
            this.Controls.Add(this.PartAddCancel);
            this.Controls.Add(this.PartAddSave);
            this.Controls.Add(this.PartMintxt);
            this.Controls.Add(this.PartMaxtxt);
            this.Controls.Add(this.PartMachineIDtxt);
            this.Controls.Add(this.PartPricetxt);
            this.Controls.Add(this.PartInventorytxt);
            this.Controls.Add(this.PartNametxt);
            this.Controls.Add(this.PartIDtxt);
            this.Controls.Add(this.AddPartMachineID);
            this.Controls.Add(this.AddPartMin);
            this.Controls.Add(this.AddPartMax);
            this.Controls.Add(this.AddPartPrice);
            this.Controls.Add(this.PartAddInventory);
            this.Controls.Add(this.PartAddName);
            this.Controls.Add(this.PartAddID);
            this.Controls.Add(this.AddOutsourced);
            this.Controls.Add(this.AddInhouse);
            this.Controls.Add(this.AddPartFormLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartFormLabel;
        private System.Windows.Forms.RadioButton AddInhouse;
        private System.Windows.Forms.RadioButton AddOutsourced;
        private System.Windows.Forms.Label PartAddID;
        private System.Windows.Forms.Label PartAddName;
        private System.Windows.Forms.Label PartAddInventory;
        private System.Windows.Forms.Label AddPartPrice;
        private System.Windows.Forms.Label AddPartMax;
        private System.Windows.Forms.Label AddPartMin;
        private System.Windows.Forms.Label AddPartMachineID;
        private System.Windows.Forms.TextBox PartIDtxt;
        private System.Windows.Forms.TextBox PartNametxt;
        private System.Windows.Forms.TextBox PartInventorytxt;
        private System.Windows.Forms.TextBox PartPricetxt;
        private System.Windows.Forms.TextBox PartMachineIDtxt;
        private System.Windows.Forms.TextBox PartMaxtxt;
        private System.Windows.Forms.TextBox PartMintxt;
        private System.Windows.Forms.Button PartAddSave;
        private System.Windows.Forms.Button PartAddCancel;
    }
}