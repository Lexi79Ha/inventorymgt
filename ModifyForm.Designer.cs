namespace C968
{
    partial class ModifyForm
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
            this.ModifyPartFormLabel = new System.Windows.Forms.Label();
            this.PartModifyInhouse = new System.Windows.Forms.RadioButton();
            this.PartModify = new System.Windows.Forms.RadioButton();
            this.PartModifyID = new System.Windows.Forms.Label();
            this.PartModifyName = new System.Windows.Forms.Label();
            this.PartModifyInventory = new System.Windows.Forms.Label();
            this.PartModifyPrice = new System.Windows.Forms.Label();
            this.PartModifyMax = new System.Windows.Forms.Label();
            this.PartModifyMin = new System.Windows.Forms.Label();
            this.PartModifyMachineID = new System.Windows.Forms.Label();
            this.PartModifyIDtxt = new System.Windows.Forms.TextBox();
            this.PartModifyNametxt = new System.Windows.Forms.TextBox();
            this.PartsModifyInventorytxt = new System.Windows.Forms.TextBox();
            this.PartsModifyPricetxt = new System.Windows.Forms.TextBox();
            this.PartsModifyMaxtxt = new System.Windows.Forms.TextBox();
            this.PartsModifyMintxt = new System.Windows.Forms.TextBox();
            this.PartsModifyMachineIDtxt = new System.Windows.Forms.TextBox();
            this.PartModifySave = new System.Windows.Forms.Button();
            this.PartModifyCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModifyPartFormLabel
            // 
            this.ModifyPartFormLabel.AutoSize = true;
            this.ModifyPartFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ModifyPartFormLabel.Location = new System.Drawing.Point(6, 17);
            this.ModifyPartFormLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ModifyPartFormLabel.Name = "ModifyPartFormLabel";
            this.ModifyPartFormLabel.Size = new System.Drawing.Size(79, 17);
            this.ModifyPartFormLabel.TabIndex = 0;
            this.ModifyPartFormLabel.Text = "Modify Part";
            // 
            // PartModifyInhouse
            // 
            this.PartModifyInhouse.AutoSize = true;
            this.PartModifyInhouse.Location = new System.Drawing.Point(210, 17);
            this.PartModifyInhouse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartModifyInhouse.Name = "PartModifyInhouse";
            this.PartModifyInhouse.Size = new System.Drawing.Size(116, 29);
            this.PartModifyInhouse.TabIndex = 1;
            this.PartModifyInhouse.TabStop = true;
            this.PartModifyInhouse.Text = "In-House";
            this.PartModifyInhouse.UseVisualStyleBackColor = true;
            this.PartModifyInhouse.CheckedChanged += new System.EventHandler(this.PartModifyInhouse_CheckedChanged);
            // 
            // PartModify
            // 
            this.PartModify.AutoSize = true;
            this.PartModify.Location = new System.Drawing.Point(358, 17);
            this.PartModify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartModify.Name = "PartModify";
            this.PartModify.Size = new System.Drawing.Size(141, 29);
            this.PartModify.TabIndex = 2;
            this.PartModify.TabStop = true;
            this.PartModify.Text = "Outsourced";
            this.PartModify.UseVisualStyleBackColor = true;
            this.PartModify.CheckedChanged += new System.EventHandler(this.PartModify_CheckedChanged);
            // 
            // PartModifyID
            // 
            this.PartModifyID.AutoSize = true;
            this.PartModifyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartModifyID.Location = new System.Drawing.Point(168, 104);
            this.PartModifyID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartModifyID.Name = "PartModifyID";
            this.PartModifyID.Size = new System.Drawing.Size(20, 16);
            this.PartModifyID.TabIndex = 3;
            this.PartModifyID.Text = "ID";
            // 
            // PartModifyName
            // 
            this.PartModifyName.AutoSize = true;
            this.PartModifyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartModifyName.Location = new System.Drawing.Point(122, 167);
            this.PartModifyName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartModifyName.Name = "PartModifyName";
            this.PartModifyName.Size = new System.Drawing.Size(44, 16);
            this.PartModifyName.TabIndex = 4;
            this.PartModifyName.Text = "Name";
            // 
            // PartModifyInventory
            // 
            this.PartModifyInventory.AutoSize = true;
            this.PartModifyInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartModifyInventory.Location = new System.Drawing.Point(88, 242);
            this.PartModifyInventory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartModifyInventory.Name = "PartModifyInventory";
            this.PartModifyInventory.Size = new System.Drawing.Size(61, 16);
            this.PartModifyInventory.TabIndex = 5;
            this.PartModifyInventory.Text = "Inventory";
            // 
            // PartModifyPrice
            // 
            this.PartModifyPrice.AutoSize = true;
            this.PartModifyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartModifyPrice.Location = new System.Drawing.Point(60, 319);
            this.PartModifyPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartModifyPrice.Name = "PartModifyPrice";
            this.PartModifyPrice.Size = new System.Drawing.Size(75, 16);
            this.PartModifyPrice.TabIndex = 6;
            this.PartModifyPrice.Text = "Price / Cost";
            // 
            // PartModifyMax
            // 
            this.PartModifyMax.AutoSize = true;
            this.PartModifyMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartModifyMax.Location = new System.Drawing.Point(144, 381);
            this.PartModifyMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartModifyMax.Name = "PartModifyMax";
            this.PartModifyMax.Size = new System.Drawing.Size(32, 16);
            this.PartModifyMax.TabIndex = 7;
            this.PartModifyMax.Text = "Max";
            // 
            // PartModifyMin
            // 
            this.PartModifyMin.AutoSize = true;
            this.PartModifyMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartModifyMin.Location = new System.Drawing.Point(394, 381);
            this.PartModifyMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartModifyMin.Name = "PartModifyMin";
            this.PartModifyMin.Size = new System.Drawing.Size(28, 16);
            this.PartModifyMin.TabIndex = 8;
            this.PartModifyMin.Text = "Min";
            // 
            // PartModifyMachineID
            // 
            this.PartModifyMachineID.AutoSize = true;
            this.PartModifyMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PartModifyMachineID.Location = new System.Drawing.Point(16, 467);
            this.PartModifyMachineID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartModifyMachineID.Name = "PartModifyMachineID";
            this.PartModifyMachineID.Size = new System.Drawing.Size(74, 16);
            this.PartModifyMachineID.TabIndex = 9;
            this.PartModifyMachineID.Text = "Machine ID";
            // 
            // PartModifyIDtxt
            // 
            this.PartModifyIDtxt.Location = new System.Drawing.Point(250, 96);
            this.PartModifyIDtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartModifyIDtxt.Name = "PartModifyIDtxt";
            this.PartModifyIDtxt.ReadOnly = true;
            this.PartModifyIDtxt.Size = new System.Drawing.Size(196, 31);
            this.PartModifyIDtxt.TabIndex = 10;
            // 
            // PartModifyNametxt
            // 
            this.PartModifyNametxt.Location = new System.Drawing.Point(250, 167);
            this.PartModifyNametxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartModifyNametxt.Name = "PartModifyNametxt";
            this.PartModifyNametxt.Size = new System.Drawing.Size(196, 31);
            this.PartModifyNametxt.TabIndex = 11;
            // 
            // PartsModifyInventorytxt
            // 
            this.PartsModifyInventorytxt.Location = new System.Drawing.Point(250, 242);
            this.PartsModifyInventorytxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartsModifyInventorytxt.Name = "PartsModifyInventorytxt";
            this.PartsModifyInventorytxt.Size = new System.Drawing.Size(196, 31);
            this.PartsModifyInventorytxt.TabIndex = 12;
            this.PartsModifyInventorytxt.TextChanged += new System.EventHandler(this.PartsModifyInventorytxt_TextChanged);
            // 
            // PartsModifyPricetxt
            // 
            this.PartsModifyPricetxt.Location = new System.Drawing.Point(250, 312);
            this.PartsModifyPricetxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartsModifyPricetxt.Name = "PartsModifyPricetxt";
            this.PartsModifyPricetxt.Size = new System.Drawing.Size(196, 31);
            this.PartsModifyPricetxt.TabIndex = 13;
            this.PartsModifyPricetxt.TextChanged += new System.EventHandler(this.PartsModifyPricetxt_TextChanged);
            // 
            // PartsModifyMaxtxt
            // 
            this.PartsModifyMaxtxt.Location = new System.Drawing.Point(250, 381);
            this.PartsModifyMaxtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartsModifyMaxtxt.Name = "PartsModifyMaxtxt";
            this.PartsModifyMaxtxt.Size = new System.Drawing.Size(122, 31);
            this.PartsModifyMaxtxt.TabIndex = 14;
            this.PartsModifyMaxtxt.TextChanged += new System.EventHandler(this.PartsModifyMaxtxt_TextChanged);
            // 
            // PartsModifyMintxt
            // 
            this.PartsModifyMintxt.Location = new System.Drawing.Point(462, 381);
            this.PartsModifyMintxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartsModifyMintxt.Name = "PartsModifyMintxt";
            this.PartsModifyMintxt.Size = new System.Drawing.Size(122, 31);
            this.PartsModifyMintxt.TabIndex = 15;
            this.PartsModifyMintxt.TextChanged += new System.EventHandler(this.PartsModifyMintxt_TextChanged);
            // 
            // PartsModifyMachineIDtxt
            // 
            this.PartsModifyMachineIDtxt.Location = new System.Drawing.Point(250, 460);
            this.PartsModifyMachineIDtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartsModifyMachineIDtxt.Name = "PartsModifyMachineIDtxt";
            this.PartsModifyMachineIDtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PartsModifyMachineIDtxt.Size = new System.Drawing.Size(196, 31);
            this.PartsModifyMachineIDtxt.TabIndex = 16;
            this.PartsModifyMachineIDtxt.TextChanged += new System.EventHandler(this.PartsModifyMachineIDtxt_TextChanged);
            // 
            // PartModifySave
            // 
            this.PartModifySave.Location = new System.Drawing.Point(358, 575);
            this.PartModifySave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartModifySave.Name = "PartModifySave";
            this.PartModifySave.Size = new System.Drawing.Size(100, 67);
            this.PartModifySave.TabIndex = 17;
            this.PartModifySave.Text = "Save";
            this.PartModifySave.UseVisualStyleBackColor = true;
            this.PartModifySave.Click += new System.EventHandler(this.PartModifySave_Click);
            // 
            // PartModifyCancel
            // 
            this.PartModifyCancel.Location = new System.Drawing.Point(488, 575);
            this.PartModifyCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartModifyCancel.Name = "PartModifyCancel";
            this.PartModifyCancel.Size = new System.Drawing.Size(100, 67);
            this.PartModifyCancel.TabIndex = 18;
            this.PartModifyCancel.Text = "Cancel";
            this.PartModifyCancel.UseVisualStyleBackColor = true;
            this.PartModifyCancel.Click += new System.EventHandler(this.PartModifyCancel_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 713);
            this.Controls.Add(this.PartModifyCancel);
            this.Controls.Add(this.PartModifySave);
            this.Controls.Add(this.PartsModifyMachineIDtxt);
            this.Controls.Add(this.PartsModifyMintxt);
            this.Controls.Add(this.PartsModifyMaxtxt);
            this.Controls.Add(this.PartsModifyPricetxt);
            this.Controls.Add(this.PartsModifyInventorytxt);
            this.Controls.Add(this.PartModifyNametxt);
            this.Controls.Add(this.PartModifyIDtxt);
            this.Controls.Add(this.PartModifyMachineID);
            this.Controls.Add(this.PartModifyMin);
            this.Controls.Add(this.PartModifyMax);
            this.Controls.Add(this.PartModifyPrice);
            this.Controls.Add(this.PartModifyInventory);
            this.Controls.Add(this.PartModifyName);
            this.Controls.Add(this.PartModifyID);
            this.Controls.Add(this.PartModify);
            this.Controls.Add(this.PartModifyInhouse);
            this.Controls.Add(this.ModifyPartFormLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyPartFormLabel;
        private System.Windows.Forms.RadioButton PartModifyInhouse;
        private System.Windows.Forms.RadioButton PartModify;
        private System.Windows.Forms.Label PartModifyID;
        private System.Windows.Forms.Label PartModifyName;
        private System.Windows.Forms.Label PartModifyInventory;
        private System.Windows.Forms.Label PartModifyPrice;
        private System.Windows.Forms.Label PartModifyMax;
        private System.Windows.Forms.Label PartModifyMin;
        private System.Windows.Forms.Label PartModifyMachineID;
        private System.Windows.Forms.TextBox PartModifyIDtxt;
        private System.Windows.Forms.TextBox PartModifyNametxt;
        private System.Windows.Forms.TextBox PartsModifyInventorytxt;
        private System.Windows.Forms.TextBox PartsModifyPricetxt;
        private System.Windows.Forms.TextBox PartsModifyMaxtxt;
        private System.Windows.Forms.TextBox PartsModifyMintxt;
        private System.Windows.Forms.TextBox PartsModifyMachineIDtxt;
        private System.Windows.Forms.Button PartModifySave;
        private System.Windows.Forms.Button PartModifyCancel;
    }
}