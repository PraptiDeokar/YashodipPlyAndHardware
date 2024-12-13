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
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtcurr
            // 
            txtcurr.Location = new Point(9, 62);
            txtcurr.Name = "txtcurr";
            txtcurr.ReadOnly = true;
            txtcurr.Size = new Size(210, 31);
            txtcurr.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(33, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(699, 86);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "How to manage stock";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(475, 41);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(113, 27);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Manually";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(278, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 27);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sell";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(63, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(114, 27);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Purshase";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 27);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 8;
            label2.Text = "Current Stock";
            // 
            // txtchange
            // 
            txtchange.Location = new Point(362, 61);
            txtchange.Name = "txtchange";
            txtchange.Size = new Size(209, 31);
            txtchange.TabIndex = 9;
            txtchange.TextChanged += txtchange_TextChanged;
            // 
            // txtup
            // 
            txtup.Location = new Point(361, 100);
            txtup.Name = "txtup";
            txtup.ReadOnly = true;
            txtup.Size = new Size(202, 31);
            txtup.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 106);
            label3.Name = "label3";
            label3.Size = new Size(21, 23);
            label3.TabIndex = 11;
            label3.Text = "=";
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(270, 376);
            button2.Name = "button2";
            button2.Size = new Size(157, 39);
            button2.TabIndex = 12;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 106);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 13;
            label4.Text = "Updated Stock Value";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Location = new Point(578, 52);
            button1.Name = "button1";
            button1.Size = new Size(111, 44);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 61);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 15;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(25, 25);
            lblname.Name = "lblname";
            lblname.Size = new Size(62, 23);
            lblname.TabIndex = 3;
            lblname.Text = "label1";
            // 
            // lblmodify
            // 
            lblmodify.AutoSize = true;
            lblmodify.Location = new Point(248, 62);
            lblmodify.Name = "lblmodify";
            lblmodify.Size = new Size(95, 23);
            lblmodify.TabIndex = 16;
            lblmodify.Text = "Modify To";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblmodify);
            panel1.Controls.Add(txtcurr);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtchange);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtup);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(33, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 149);
            panel1.TabIndex = 17;
            // 
            // UpdateStock
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(755, 437);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(lblname);
            Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Name = "UpdateStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateStock";
            Load += UpdateStock_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}