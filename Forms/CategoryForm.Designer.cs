namespace YashodipPlyAndHardware
{
    partial class CategoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblCategory = new Label();
            btnSave = new Button();
            txtCategory = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(40, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 25);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(208, 146);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(161, 94);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Enter Category Name";
            txtCategory.Size = new Size(275, 31);
            txtCategory.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 71);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(375, 17);
            button1.Name = "button1";
            button1.Size = new Size(47, 34);
            button1.TabIndex = 42;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            label8.Location = new Point(95, 9);
            label8.Name = "label8";
            label8.Size = new Size(202, 41);
            label8.TabIndex = 0;
            label8.Text = "Add Category";
            label8.Click += label8_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Enter Category";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 202);
            Controls.Add(panel1);
            Controls.Add(txtCategory);
            Controls.Add(btnSave);
            Controls.Add(lblCategory);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Category";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Button btnSave;
        private TextBox txtCategory;
        private Panel panel1;
        private Button button2;
        private Label label8;
        private Button button1;
        private ToolTip toolTip1;
    }
}
