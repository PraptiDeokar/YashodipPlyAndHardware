namespace YashodipPlyAndHardware.Forms
{
    partial class UpdateStock
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
            txtcurr = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            txtchange = new TextBox();
            txtup = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            label1 = new Label();
            lblname = new Label();
            lblmodify = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtcurr
            // 
            txtcurr.Location = new Point(12, 220);
            txtcurr.Name = "txtcurr";
            txtcurr.ReadOnly = true;
            txtcurr.Size = new Size(191, 31);
            txtcurr.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(30, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 93);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "How to manage stock";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(341, 48);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(108, 29);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Manually";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(199, 48);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 29);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sell";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Purshase";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 182);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 8;
            label2.Text = "Current Stock";
            // 
            // txtchange
            // 
            txtchange.Location = new Point(333, 218);
            txtchange.Name = "txtchange";
            txtchange.Size = new Size(190, 31);
            txtchange.TabIndex = 9;
            // 
            // txtup
            // 
            txtup.Location = new Point(333, 299);
            txtup.Name = "txtup";
            txtup.ReadOnly = true;
            txtup.Size = new Size(184, 31);
            txtup.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 305);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 11;
            label3.Text = "=";
            // 
            // button2
            // 
            button2.Location = new Point(229, 377);
            button2.Name = "button2";
            button2.Size = new Size(143, 42);
            button2.TabIndex = 12;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 305);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 13;
            label4.Text = "Updated Stock Value";
            // 
            // button1
            // 
            button1.Location = new Point(529, 213);
            button1.Name = "button1";
            button1.Size = new Size(101, 38);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 218);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 15;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(23, 27);
            lblname.Name = "lblname";
            lblname.Size = new Size(59, 25);
            lblname.TabIndex = 3;
            lblname.Text = "label1";
            // 
            // lblmodify
            // 
            lblmodify.AutoSize = true;
            lblmodify.Location = new Point(235, 220);
            lblmodify.Name = "lblmodify";
            lblmodify.Size = new Size(92, 25);
            lblmodify.TabIndex = 16;
            lblmodify.Text = "Modify To";
            // 
            // UpdateStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 442);
            Controls.Add(lblmodify);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtup);
            Controls.Add(txtchange);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(lblname);
            Controls.Add(txtcurr);
            Name = "UpdateStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateStock";
            Load += UpdateStock_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtcurr;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private TextBox txtchange;
        private TextBox txtup;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button1;
        private Label label1;
        private Label lblname;
        private Label lblmodify;
    }
}