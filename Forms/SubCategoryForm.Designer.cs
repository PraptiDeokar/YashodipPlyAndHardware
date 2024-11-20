namespace YashodipPlyAndHardware.Forms
{
    partial class SubCategoryForm
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
            btnSave = new Button();
            cmbCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtSubCategory = new TextBox();
            btnAddCategory = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(123, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(50, 200);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(262, 33);
            cmbCategory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 172);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 92);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 3;
            label2.Text = "Sub-Category Name";
            // 
            // txtSubCategory
            // 
            txtSubCategory.Location = new Point(50, 120);
            txtSubCategory.Name = "txtSubCategory";
            txtSubCategory.Size = new Size(260, 31);
            txtSubCategory.TabIndex = 4;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(238, 160);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(37, 34);
            btnAddCategory.TabIndex = 5;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 71);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(304, 16);
            button1.Name = "button1";
            button1.Size = new Size(47, 34);
            button1.TabIndex = 42;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(573, 12);
            button2.Name = "button2";
            button2.Size = new Size(47, 34);
            button2.TabIndex = 41;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(39, 8);
            label8.Name = "label8";
            label8.Size = new Size(248, 41);
            label8.TabIndex = 0;
            label8.Text = "Add Subcategory";
            // 
            // SubCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 320);
            Controls.Add(panel1);
            Controls.Add(btnAddCategory);
            Controls.Add(txtSubCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SubCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Sub-Category";
            Load += SubCategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cmbCategory;
        private Label label1;
        private Label label2;
        private TextBox txtSubCategory;
        private Button btnAddCategory;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label8;
    }
}