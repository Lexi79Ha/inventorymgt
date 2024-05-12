namespace C968
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Form1Label = new System.Windows.Forms.Label();
            this.PartAdd = new System.Windows.Forms.Button();
            this.PartModify = new System.Windows.Forms.Button();
            this.PartDelete = new System.Windows.Forms.Button();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.ProductModify = new System.Windows.Forms.Button();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.Button();
            this.ProductSearch = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.PartSearchtxt = new System.Windows.Forms.TextBox();
            this.ProductSearchtxt = new System.Windows.Forms.TextBox();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.Productlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(956, 154);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(876, 360);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 360);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1Label
            // 
            this.Form1Label.AutoSize = true;
            this.Form1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Form1Label.Location = new System.Drawing.Point(6, 17);
            this.Form1Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form1Label.Name = "Form1Label";
            this.Form1Label.Size = new System.Drawing.Size(229, 20);
            this.Form1Label.TabIndex = 3;
            this.Form1Label.Text = "Inventory Managment System";
            // 
            // PartAdd
            // 
            this.PartAdd.Location = new System.Drawing.Point(514, 525);
            this.PartAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartAdd.Name = "PartAdd";
            this.PartAdd.Size = new System.Drawing.Size(110, 60);
            this.PartAdd.TabIndex = 4;
            this.PartAdd.Text = "Add";
            this.PartAdd.UseVisualStyleBackColor = true;
            this.PartAdd.Click += new System.EventHandler(this.PartAdd_Click);
            // 
            // PartModify
            // 
            this.PartModify.Location = new System.Drawing.Point(636, 525);
            this.PartModify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartModify.Name = "PartModify";
            this.PartModify.Size = new System.Drawing.Size(110, 60);
            this.PartModify.TabIndex = 5;
            this.PartModify.Text = "Modify";
            this.PartModify.UseVisualStyleBackColor = true;
            this.PartModify.Click += new System.EventHandler(this.PartModify_Click);
            // 
            // PartDelete
            // 
            this.PartDelete.Location = new System.Drawing.Point(758, 525);
            this.PartDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartDelete.Name = "PartDelete";
            this.PartDelete.Size = new System.Drawing.Size(110, 60);
            this.PartDelete.TabIndex = 6;
            this.PartDelete.Text = "Delete";
            this.PartDelete.UseVisualStyleBackColor = true;
            this.PartDelete.Click += new System.EventHandler(this.PartDelete_Click);
            // 
            // ProductAdd
            // 
            this.ProductAdd.Location = new System.Drawing.Point(1478, 525);
            this.ProductAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(110, 60);
            this.ProductAdd.TabIndex = 7;
            this.ProductAdd.Text = "Add";
            this.ProductAdd.UseVisualStyleBackColor = true;
            this.ProductAdd.Click += new System.EventHandler(this.ProductAdd_Click);
            // 
            // ProductModify
            // 
            this.ProductModify.Location = new System.Drawing.Point(1600, 525);
            this.ProductModify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductModify.Name = "ProductModify";
            this.ProductModify.Size = new System.Drawing.Size(110, 60);
            this.ProductModify.TabIndex = 8;
            this.ProductModify.Text = "Modify";
            this.ProductModify.UseVisualStyleBackColor = true;
            this.ProductModify.Click += new System.EventHandler(this.ProductModify_Click);
            // 
            // ProductDelete
            // 
            this.ProductDelete.Location = new System.Drawing.Point(1722, 525);
            this.ProductDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(110, 60);
            this.ProductDelete.TabIndex = 9;
            this.ProductDelete.Text = "Delete";
            this.ProductDelete.UseVisualStyleBackColor = true;
            this.ProductDelete.Click += new System.EventHandler(this.ProductDelete_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(444, 113);
            this.PartSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(110, 38);
            this.PartSearch.TabIndex = 10;
            this.PartSearch.Text = "Search";
            this.PartSearch.UseVisualStyleBackColor = true;
            this.PartSearch.Click += new System.EventHandler(this.PartSearch_Click);
            // 
            // ProductSearch
            // 
            this.ProductSearch.Location = new System.Drawing.Point(1408, 108);
            this.ProductSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(110, 38);
            this.ProductSearch.TabIndex = 11;
            this.ProductSearch.Text = "Search";
            this.ProductSearch.UseVisualStyleBackColor = true;
            this.ProductSearch.Click += new System.EventHandler(this.ProductSearch_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1722, 677);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 60);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // PartSearchtxt
            // 
            this.PartSearchtxt.Location = new System.Drawing.Point(566, 110);
            this.PartSearchtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PartSearchtxt.Name = "PartSearchtxt";
            this.PartSearchtxt.Size = new System.Drawing.Size(298, 31);
            this.PartSearchtxt.TabIndex = 13;
            // 
            // ProductSearchtxt
            // 
            this.ProductSearchtxt.Location = new System.Drawing.Point(1530, 108);
            this.ProductSearchtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductSearchtxt.Name = "ProductSearchtxt";
            this.ProductSearchtxt.Size = new System.Drawing.Size(298, 31);
            this.ProductSearchtxt.TabIndex = 14;
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PartsLabel.Location = new System.Drawing.Point(24, 115);
            this.PartsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(41, 17);
            this.PartsLabel.TabIndex = 15;
            this.PartsLabel.Text = "Parts";
            // 
            // Productlabel
            // 
            this.Productlabel.AutoSize = true;
            this.Productlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Productlabel.Location = new System.Drawing.Point(950, 115);
            this.Productlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Productlabel.Name = "Productlabel";
            this.Productlabel.Size = new System.Drawing.Size(64, 17);
            this.Productlabel.TabIndex = 16;
            this.Productlabel.Text = "Products";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 760);
            this.Controls.Add(this.Productlabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.ProductSearchtxt);
            this.Controls.Add(this.PartSearchtxt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ProductSearch);
            this.Controls.Add(this.PartSearch);
            this.Controls.Add(this.ProductDelete);
            this.Controls.Add(this.ProductModify);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.PartDelete);
            this.Controls.Add(this.PartModify);
            this.Controls.Add(this.PartAdd);
            this.Controls.Add(this.Form1Label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Form1Label;
        private System.Windows.Forms.Button PartAdd;
        private System.Windows.Forms.Button PartModify;
        private System.Windows.Forms.Button PartDelete;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.Button ProductModify;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Button PartSearch;
        private System.Windows.Forms.Button ProductSearch;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox PartSearchtxt;
        private System.Windows.Forms.TextBox ProductSearchtxt;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label Productlabel;
    }
}

