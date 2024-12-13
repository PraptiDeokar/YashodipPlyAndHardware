namespace YashodipPlyAndHardware.View
{
    partial class SubcategoryView
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
            label2 = new Label();
            textBox1 = new TextBox();
            btnAddCategory = new Button();
            label1 = new Label();
            txtSubCategory = new TextBox();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnAddCategory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSubCategory);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 169);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 12;
            label2.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 123);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Subcategory";
            textBox1.Size = new Size(294, 29);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.ForeColor = Color.MediumVioletRed;
            btnAddCategory.Location = new Point(316, 12);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(46, 46);
            btnAddCategory.TabIndex = 11;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 29);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 9;
            label1.Text = "Sub-Category Name";
            // 
            // txtSubCategory
            // 
            txtSubCategory.Location = new Point(417, 65);
            txtSubCategory.Name = "txtSubCategory";
            txtSubCategory.PlaceholderText = "Enter Subcategory";
            txtSubCategory.Size = new Size(324, 29);
            txtSubCategory.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.Location = new Point(760, 60);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 47);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(34, 63);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(362, 29);
            cmbCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 34);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 8;
            label3.Text = "Category";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 364);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(921, 364);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(857, 7);
            button1.Name = "button1";
            button1.Size = new Size(61, 51);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SubcategoryView
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SubcategoryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubcategoryView";
            Load += SubcategoryView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnAddCategory;
        private Label label1;
        private TextBox txtSubCategory;
        private Button btnSave;
        private ComboBox cmbCategory;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}