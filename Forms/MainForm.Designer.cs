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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            lblmarque = new Label();
            panel4 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 631);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 420);
            label5.Name = "label5";
            label5.Size = new Size(212, 40);
            label5.TabIndex = 7;
            label5.Text = "Hardware";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(128, 352);
            label4.Name = "label4";
            label4.Size = new Size(46, 40);
            label4.TabIndex = 6;
            label4.Text = "&&";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(41, 352);
            label3.Name = "label3";
            label3.Size = new Size(81, 40);
            label3.TabIndex = 5;
            label3.Text = "ply";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(21, 287);
            label2.Name = "label2";
            label2.Size = new Size(186, 40);
            label2.TabIndex = 4;
            label2.Text = "YAshodip";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.ForeColor = SystemColors.ControlLightLight;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(26, 574);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 32);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.K;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Navy;
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(886, 12);
            button10.Name = "button10";
            button10.Size = new Size(143, 47);
            button10.TabIndex = 8;
            button10.Text = "SubType";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Navy;
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(1048, 12);
            button9.Name = "button9";
            button9.Size = new Size(143, 47);
            button9.TabIndex = 7;
            button9.Text = "Category";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Navy;
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(379, 12);
            button8.Name = "button8";
            button8.Size = new Size(143, 47);
            button8.TabIndex = 6;
            button8.Text = "Manage Stock";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Navy;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(548, 12);
            button7.Name = "button7";
            button7.Size = new Size(143, 47);
            button7.TabIndex = 5;
            button7.Text = "Customers";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(720, 12);
            button6.Name = "button6";
            button6.Size = new Size(143, 47);
            button6.TabIndex = 4;
            button6.Text = "Item/Size";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(211, 12);
            button5.Name = "button5";
            button5.Size = new Size(143, 47);
            button5.TabIndex = 3;
            button5.Text = "Bills";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(47, 12);
            button4.Name = "button4";
            button4.Size = new Size(143, 47);
            button4.TabIndex = 2;
            button4.Text = "New Bill";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.ForeColor = SystemColors.Highlight;
            panel3.Location = new Point(236, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1531, 73);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1197, 12);
            button1.Name = "button1";
            button1.Size = new Size(143, 47);
            button1.TabIndex = 5;
            button1.Text = "Sales";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1369, 16);
            label1.Margin = new Padding(3, 0, 5, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 70, 0);
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(148, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(lblmarque);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(236, 551);
            panel2.Name = "panel2";
            panel2.Size = new Size(1531, 80);
            panel2.TabIndex = 3;
            // 
            // lblmarque
            // 
            lblmarque.BackColor = Color.DodgerBlue;
            lblmarque.BorderStyle = BorderStyle.FixedSingle;
            lblmarque.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblmarque.ForeColor = SystemColors.ButtonHighlight;
            lblmarque.Location = new Point(67, 17);
            lblmarque.Name = "lblmarque";
            lblmarque.Size = new Size(1363, 38);
            lblmarque.TabIndex = 0;
            lblmarque.Text = "label2";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(236, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(1531, 478);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1767, 631);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YASHODIP PLY ";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button10;
        private Button button9;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private LinkLabel linkLabel1;
        private Label lblmarque;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button button1;
    }
}