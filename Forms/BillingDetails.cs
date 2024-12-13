using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YashodipPly.Forms;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.Models;

namespace YashodipPlyAndHardware.Forms
{
    public partial class BillingDetails : Form
    {
        Bill bill;
        public BillingDetails()
        {
            InitializeComponent();
        }
        private void LoadBillingData()
        {
            AppDBContext db = new AppDBContext();

            try
            {

                var Bill = db.BillMaster.Select(p => new
                {
                    BillId = p.BillId,
                    p.Date,
                    Customer = p.CustomerName,
                    p.City,
                    p.FinalTotal,

                }).ToList();

                dataGridView1.DataSource = Bill;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        private void BillingDetails_Load(object sender, EventArgs e)
        {
            LoadBillingData();
            AppDBContext db = new AppDBContext();

            DataGridViewButtonColumn showButtonColumn = new DataGridViewButtonColumn();
            showButtonColumn.Name = "Show Details";
            showButtonColumn.HeaderText = "Show Details";
            showButtonColumn.Text = "Show Details";
            showButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(showButtonColumn);


           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                txtname.Enabled = true;
            else
                txtname.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked))
            {
                panel3.Enabled = true;
            }
            else
            {
                panel3.Enabled = false;
            }

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                AppDBContext db = new AppDBContext();

                try
                {

                    var Bill = db.BillMaster.Select(p => new
                    {
                        BillId = p.BillId,
                        p.Date,
                        Customer = p.CustomerName,
                        p.City,
                        p.FinalTotal,

                    }).Where(b => b.Customer.Contains(txtname.Text)).ToList();

                    dataGridView1.DataSource = Bill;


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }

            }
            else
            {
                LoadBillingData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datefrom = Convert.ToDateTime(dateTimePicker1.Text).Date;

            DateTime dateto = Convert.ToDateTime(dateTimePicker2.Text).Date;


            AppDBContext db = new AppDBContext();

            try
            {
                if (txtname.Enabled && checkBox2.Checked && checkBox1.Checked)
                {
                    var Bill = db.BillMaster
                    .Where(b => b.CustomerName.Contains(txtname.Text)
                      && b.Date >= dateTimePicker1.Value.Date && b.Date <= dateTimePicker2.Value.Date)
          .Select(p => new
          {
              BillId = p.BillId,
              p.Date,
              Customer = p.CustomerName,
              p.City,
              p.FinalTotal,
          })
          .ToList();

                    dataGridView1.DataSource = Bill;
                }
                else if (checkBox1.Checked)
                {
                    var Bill = db.BillMaster
                    .Where(b => b.Date >= dateTimePicker1.Value.Date && b.Date <= dateTimePicker2.Value.Date)
          .Select(p => new
          {
              BillId = p.BillId,
              p.Date,
              Customer = p.CustomerName,
              p.City,
              p.FinalTotal,
          })
          .ToList();

                    dataGridView1.DataSource = Bill;
                }

                else
                {
                    LoadBillingData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AppDBContext db = new AppDBContext();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Show Details")
                {
                    // Get the selected row's data (e.g., ID of the record)
                    int billid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BillId"].Value);

                    bill = db.BillMaster.Find(billid);
                    var bc = db.BillChild.Where(c => c.BillId == billid).ToList();
                    if (bill != null)
                    {
                        Bill billobj = new Bill();
                        billobj.BillId = billid;
                        billobj.CustomerName = bill.CustomerName;
                        billobj.MobileNumber = bill.MobileNumber;
                        billobj.Date = bill.Date;
                        billobj.Email = bill.Email;
                        billobj.City = bill.City;
                        billobj.DisAmt = bill.DisAmt;
                        billobj.GstAmt = bill.GstAmt;
                        billobj.Tot = bill.Tot;
                        billobj.FinalTotal = bill.FinalTotal;
                    }
                    NewBill nb = new NewBill();
                    nb.GetBillDetails(bill, bc);
                    nb.Show();
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
