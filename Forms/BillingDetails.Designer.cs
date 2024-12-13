namespace YashodipPlyAndHardware.Forms
{
    partial class BillingDetails
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
            button2 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            txtname = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtname);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1469, 140);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(1396, 10);
            button2.Name = "button2";
            button2.Size = new Size(61, 43);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Location = new Point(512, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 55);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(762, 6);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 8;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 5;
            label3.Text = "Date From";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(477, 13);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(264, 31);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 17);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 4;
            label2.Text = "To";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(90, 18);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(134, 27);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Name Wise";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(512, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Datewise";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 70);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 3;
            label1.Text = "Customer Name";
            // 
            // txtname
            // 
            txtname.Enabled = false;
            txtname.Location = new Point(219, 70);
            txtname.Name = "txtname";
            txtname.Size = new Size(238, 31);
            txtname.TabIndex = 2;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(1469, 497);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1469, 497);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BillingDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 637);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "BillingDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BillingDetails";
            Load += BillingDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox txtname;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Panel panel3;
        private Button button1;
        private Button button2;
    }
}