namespace YashodipPlyAndHardware.Forms
{
    partial class SalesForm
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
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1004, 9);
            button1.Name = "button1";
            button1.Size = new Size(134, 53);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1644, 102);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(1547, 18);
            button2.Name = "button2";
            button2.Size = new Size(67, 39);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(209, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(1166, 71);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 19);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 5;
            label3.Text = "Date From";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(606, 16);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(365, 31);
            dateTimePicker2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(544, 19);
            label2.Name = "label2";
            label2.Size = new Size(32, 23);
            label2.TabIndex = 4;
            label2.Text = "To";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(354, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1644, 418);
            dataGridView1.TabIndex = 2;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 520);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SalesForm";
            Text = "SalesForm";
            Load += SalesForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
    }
}