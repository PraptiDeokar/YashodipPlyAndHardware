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
            button1 = new Button();
            cmbSearch = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
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
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cmbSearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 98);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(900, 24);
            button1.Name = "button1";
            button1.Size = new Size(61, 51);
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "Product", "Category", "Subcategory" });
            cmbSearch.Location = new Point(233, 48);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(293, 29);
            cmbSearch.TabIndex = 43;
            cmbSearch.Text = "-Select-";
            cmbSearch.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(89, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 3;
            label2.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(548, 45);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(330, 29);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(13, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
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
            panel2.Size = new Size(1695, 699);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label10);
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
            panel3.Dock = DockStyle.Left;
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 699);
            panel3.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 32);
            label10.TabIndex = 58;
            label10.Text = "Add New Product";
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DeepPink;
            button2.Location = new Point(359, 149);
            button2.Name = "button2";
            button2.Size = new Size(49, 42);
            button2.TabIndex = 57;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbSub
            // 
            cmbSub.FormattingEnabled = true;
            cmbSub.Items.AddRange(new object[] { "-Select-" });
            cmbSub.Location = new Point(22, 158);
            cmbSub.Name = "cmbSub";
            cmbSub.Size = new Size(331, 29);
            cmbSub.TabIndex = 56;
            cmbSub.SelectedIndexChanged += cmbSub_SelectedIndexChanged;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(21, 526);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(387, 101);
            txtDes.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 491);
            label7.Name = "label7";
            label7.Size = new Size(108, 21);
            label7.TabIndex = 54;
            label7.Text = "Description";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(21, 444);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(331, 29);
            txtQty.TabIndex = 53;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 412);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 52;
            label6.Text = "Quantity";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(21, 297);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(331, 29);
            txtRate.TabIndex = 51;
            txtRate.KeyPress += txtRate_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 273);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 50;
            label5.Text = "Rate";
            // 
            // txtCustRate
            // 
            txtCustRate.Location = new Point(22, 367);
            txtCustRate.Name = "txtCustRate";
            txtCustRate.Size = new Size(331, 29);
            txtCustRate.TabIndex = 49;
            txtCustRate.KeyPress += txtCustRate_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 340);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 48;
            label4.Text = "Customer's Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 134);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 47;
            label3.Text = "Sub-Category Name";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.ForeColor = Color.DeepPink;
            btnAddCategory.Location = new Point(359, 83);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(49, 41);
            btnAddCategory.TabIndex = 46;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(22, 226);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(331, 29);
            txtProduct.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 202);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 44;
            label8.Text = "Item/Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 57);
            label9.Name = "label9";
            label9.Size = new Size(84, 21);
            label9.TabIndex = 43;
            label9.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "-Select-" });
            cmbCategory.Location = new Point(22, 91);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(331, 29);
            cmbCategory.TabIndex = 42;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.Location = new Point(133, 636);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 51);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(432, 100);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1263, 595);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1695, 699);
            Controls.Add(panel2);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
        private Label label10;
        private Button button1;
    }
}