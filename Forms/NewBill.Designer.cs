namespace YashodipPly.Forms
{
    partial class NewBill
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
            txtEmail = new TextBox();
            label19 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            txtMob = new TextBox();
            label4 = new Label();
            txtCustName = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            txtBillId = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            btnSave = new Button();
            label16 = new Label();
            txtFinalTot = new TextBox();
            label15 = new Label();
            txtTotal = new TextBox();
            label14 = new Label();
            txtGST = new TextBox();
            label13 = new Label();
            txtDis = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            label20 = new Label();
            cmbCategory = new ComboBox();
            label9 = new Label();
            label18 = new Label();
            label17 = new Label();
            btnAdd = new Button();
            txtTot = new TextBox();
            label10 = new Label();
            txtqty = new TextBox();
            txtPrice = new TextBox();
            label8 = new Label();
            cmbProd = new ComboBox();
            label7 = new Label();
            cmbSub = new ComboBox();
            label6 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMob);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCustName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtBillId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1838, 122);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(1764, 18);
            button2.Name = "button2";
            button2.Size = new Size(61, 51);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1334, 24);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(393, 29);
            txtEmail.TabIndex = 13;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(1207, 29);
            label19.Name = "label19";
            label19.Size = new Size(88, 23);
            label19.TabIndex = 12;
            label19.Text = "Email ID";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(722, 75);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(459, 29);
            txtCity.TabIndex = 11;
            txtCity.KeyPress += txtCity_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(551, 72);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 10;
            label5.Text = "City/Village";
            // 
            // txtMob
            // 
            txtMob.Location = new Point(1334, 66);
            txtMob.Name = "txtMob";
            txtMob.Size = new Size(393, 29);
            txtMob.TabIndex = 9;
            txtMob.KeyPress += txtMob_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1203, 71);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 8;
            label4.Text = "Mob. No.";
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(722, 25);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(459, 29);
            txtCustName.TabIndex = 6;
            txtCustName.TextChanged += txtCustName_TextChanged;
            txtCustName.KeyPress += txtCustName_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(513, 29);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 5;
            label3.Text = "Customer Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(377, 29);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(394, 28);
            button1.Name = "button1";
            button1.Size = new Size(90, 35);
            button1.TabIndex = 2;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBillId
            // 
            txtBillId.Location = new Point(100, 31);
            txtBillId.Name = "txtBillId";
            txtBillId.ReadOnly = true;
            txtBillId.Size = new Size(281, 29);
            txtBillId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtFinalTot);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtGST);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtDis);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(0, 539);
            panel2.Name = "panel2";
            panel2.Size = new Size(1838, 149);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateBlue;
            button6.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(930, 87);
            button6.Name = "button6";
            button6.Size = new Size(140, 57);
            button6.TabIndex = 28;
            button6.Text = "PRINT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateBlue;
            btnSave.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(717, 87);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 59);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(1321, 30);
            label16.Name = "label16";
            label16.Size = new Size(34, 23);
            label16.TabIndex = 24;
            label16.Text = ">>";
            // 
            // txtFinalTot
            // 
            txtFinalTot.Location = new Point(1538, 29);
            txtFinalTot.Name = "txtFinalTot";
            txtFinalTot.Size = new Size(279, 29);
            txtFinalTot.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(871, 32);
            label15.Name = "label15";
            label15.Size = new Size(60, 23);
            label15.TabIndex = 22;
            label15.Text = " Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(961, 29);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(320, 29);
            txtTotal.TabIndex = 21;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1381, 31);
            label14.Name = "label14";
            label14.Size = new Size(106, 23);
            label14.TabIndex = 20;
            label14.Text = "Final Total";
            // 
            // txtGST
            // 
            txtGST.Location = new Point(122, 34);
            txtGST.Name = "txtGST";
            txtGST.Size = new Size(259, 29);
            txtGST.TabIndex = 19;
            txtGST.TextChanged += txtGST_TextChanged;
            txtGST.KeyPress += txtGST_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(12, 40);
            label13.Name = "label13";
            label13.Size = new Size(88, 23);
            label13.TabIndex = 18;
            label13.Text = "GST Amt";
            // 
            // txtDis
            // 
            txtDis.Location = new Point(602, 31);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(229, 29);
            txtDis.TabIndex = 14;
            txtDis.TextChanged += textBox8_TextChanged;
            txtDis.KeyPress += txtDis_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(429, 35);
            label11.Name = "label11";
            label11.Size = new Size(132, 23);
            label11.TabIndex = 13;
            label11.Text = "Discount Amt";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label20);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtTot);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtqty);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbProd);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbSub);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(1838, 128);
            panel3.TabIndex = 2;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(1437, 17);
            label20.Name = "label20";
            label20.Size = new Size(59, 26);
            label20.TabIndex = 20;
            label20.Text = "Total";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(12, 66);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(291, 29);
            cmbCategory.TabIndex = 19;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 17);
            label9.Name = "label9";
            label9.Size = new Size(96, 26);
            label9.TabIndex = 18;
            label9.Text = "Category";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Variable Small Semibol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(1709, 60);
            label18.Name = "label18";
            label18.Size = new Size(40, 27);
            label18.TabIndex = 17;
            label18.Text = ">>";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(1157, 17);
            label17.Name = "label17";
            label17.Size = new Size(42, 26);
            label17.TabIndex = 16;
            label17.Text = "qty";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(1772, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 48);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.TextChanged += btnAdd_TextChanged;
            btnAdd.Click += button3_Click;
            // 
            // txtTot
            // 
            txtTot.Location = new Point(1437, 62);
            txtTot.Name = "txtTot";
            txtTot.Size = new Size(242, 29);
            txtTot.TabIndex = 14;
            txtTot.KeyPress += txtTot_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1390, 60);
            label10.Name = "label10";
            label10.Size = new Size(26, 28);
            label10.TabIndex = 13;
            label10.Text = "=";
            // 
            // txtqty
            // 
            txtqty.Location = new Point(1157, 66);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(198, 29);
            txtqty.TabIndex = 12;
            txtqty.TextChanged += textBox6_TextChanged;
            txtqty.KeyPress += txtqty_KeyPress;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(950, 66);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(190, 29);
            txtPrice.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(961, 17);
            label8.Name = "label8";
            label8.Size = new Size(61, 26);
            label8.TabIndex = 4;
            label8.Text = "Price";
            label8.Click += label8_Click;
            // 
            // cmbProd
            // 
            cmbProd.FormattingEnabled = true;
            cmbProd.Location = new Point(612, 67);
            cmbProd.Name = "cmbProd";
            cmbProd.Size = new Size(332, 29);
            cmbProd.TabIndex = 3;
            cmbProd.SelectedIndexChanged += cmbProd_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(612, 17);
            label7.Name = "label7";
            label7.Size = new Size(104, 26);
            label7.TabIndex = 2;
            label7.Text = "Size/Item";
            // 
            // cmbSub
            // 
            cmbSub.FormattingEnabled = true;
            cmbSub.Location = new Point(309, 66);
            cmbSub.Name = "cmbSub";
            cmbSub.Size = new Size(297, 29);
            cmbSub.TabIndex = 1;
            cmbSub.SelectedIndexChanged += cmbSub_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(308, 17);
            label6.Name = "label6";
            label6.Size = new Size(131, 26);
            label6.TabIndex = 0;
            label6.Text = "SubCategory";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(1838, 289);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1838, 289);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NewBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1838, 688);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NewBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewBill";
            Load += NewBill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox txtBillId;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtCity;
        private Label label5;
        private TextBox txtMob;
        private Label label4;
        private TextBox txtCustName;
        private ComboBox cmbProd;
        private Label label7;
        private ComboBox cmbSub;
        private Label label6;
        private Panel panel4;
        private Label label8;
        private Button btnAdd;
        private TextBox txtTot;
        private Label label10;
        private TextBox txtqty;
        private TextBox txtPrice;
        private DataGridView dataGridView1;
        private TextBox txtDis;
        private Label label11;
        private TextBox txtFinalTot;
        private Label label15;
        private TextBox txtTotal;
        private Label label14;
        private TextBox txtGST;
        private Label label13;
        private Label label16;
        private Button btnSave;
        private Label label17;
        private TextBox txtEmail;
        private Label label19;
        private Button button6;
        private Label label20;
        private ComboBox cmbCategory;
        private Label label9;
        private Label label18;
        private Button button2;
    }
}