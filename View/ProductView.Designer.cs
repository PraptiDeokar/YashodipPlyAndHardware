namespace YashodipPlyAndHardware.View
{
    partial class ProductView
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
            panel1 = new Panel();
            cmbSearch = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            cmbSub = new ComboBox();
            txtDes = new TextBox();
            label7 = new Label();
            txtQty = new TextBox();
            label6 = new Label();
            txtRate = new TextBox();
            label5 = new Label();
            txtCustRate = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnAddCategory = new Button();
            txtProduct = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbSearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(595, 5);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 116);
            panel1.TabIndex = 1;
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "Product", "Category", "Subcategory", "Available Stock" });
            cmbSearch.Location = new Point(109, 62);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(211, 33);
            cmbSearch.TabIndex = 43;
            cmbSearch.Text = "-Select-";
            cmbSearch.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 3;
            label2.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(336, 62);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(246, 31);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Product List";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1364, 675);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(cmbSub);
            panel3.Controls.Add(txtDes);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtQty);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtRate);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtCustRate);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnAddCategory);
            panel3.Controls.Add(txtProduct);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(576, 636);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(235, 194);
            button2.Name = "button2";
            button2.Size = new Size(37, 34);
            button2.TabIndex = 57;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // cmbSub
            // 
            cmbSub.FormattingEnabled = true;
            cmbSub.Items.AddRange(new object[] { "-Select-" });
            cmbSub.Location = new Point(9, 247);
            cmbSub.Name = "cmbSub";
            cmbSub.Size = new Size(304, 33);
            cmbSub.TabIndex = 56;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(172, 405);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(381, 144);
            txtDes.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 445);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 54;
            label7.Text = "Description";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(348, 351);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(205, 31);
            txtQty.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 298);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 52;
            label6.Text = "Quantity";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(348, 250);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(205, 31);
            txtRate.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 199);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 50;
            label5.Text = "Rate";
            // 
            // txtCustRate
            // 
            txtCustRate.Location = new Point(348, 145);
            txtCustRate.Name = "txtCustRate";
            txtCustRate.Size = new Size(205, 31);
            txtCustRate.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 99);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 48;
            label4.Text = "Customer's Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 203);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 47;
            label3.Text = "Sub-Category Name";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(235, 90);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(37, 34);
            btnAddCategory.TabIndex = 46;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(15, 344);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(304, 31);
            txtProduct.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 298);
            label8.Name = "label8";
            label8.Size = new Size(164, 25);
            label8.TabIndex = 44;
            label8.Text = "Product Name/Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 99);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 43;
            label9.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "-Select-" });
            cmbCategory.Location = new Point(9, 144);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(304, 33);
            cmbCategory.TabIndex = 42;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(230, 579);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(595, 119);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(749, 541);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1364, 675);
            Controls.Add(panel2);
            Name = "ProductView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductView";
            Load += ProductView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button button2;
        private ComboBox cmbSub;
        private TextBox txtDes;
        private Label label7;
        private TextBox txtQty;
        private Label label6;
        private TextBox txtRate;
        private Label label5;
        private TextBox txtCustRate;
        private Label label4;
        private Label label3;
        private Button btnAddCategory;
        private TextBox txtProduct;
        private Label label8;
        private Label label9;
        private ComboBox cmbCategory;
        private Button btnSave;
        private ComboBox cmbSearch;
    }
}