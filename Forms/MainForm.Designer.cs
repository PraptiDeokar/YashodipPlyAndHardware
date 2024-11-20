namespace YashodipPlyAndHardware.Forms
{
    partial class MainForm
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
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 631);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button10
            // 
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.Location = new Point(48, 501);
            button10.Name = "button10";
            button10.Size = new Size(155, 34);
            button10.TabIndex = 8;
            button10.Text = "SubCategory";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Location = new Point(48, 448);
            button9.Name = "button9";
            button9.Size = new Size(155, 34);
            button9.TabIndex = 7;
            button9.Text = "Category";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.Location = new Point(48, 397);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 6;
            button8.Text = "Manage Stock";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.Location = new Point(48, 341);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 5;
            button7.Text = "Customers";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Location = new Point(48, 248);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 4;
            button6.Text = "Products";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Location = new Point(48, 292);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 3;
            button5.Text = "Sales";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Location = new Point(48, 208);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 2;
            button4.Text = "New Bill";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(48, 168);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(57, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 111);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(256, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 69);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(670, 16);
            button3.Name = "button3";
            button3.Size = new Size(52, 34);
            button3.TabIndex = 2;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(623, 16);
            button1.Name = "button1";
            button1.Size = new Size(41, 34);
            button1.TabIndex = 0;
            button1.Text = "-";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(256, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(767, 562);
            panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 631);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button10;
        private Button button9;
    }
}