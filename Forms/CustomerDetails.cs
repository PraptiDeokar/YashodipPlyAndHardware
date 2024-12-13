using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YashodipPlyAndHardware.Data;

namespace YashodipPlyAndHardware.Forms
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            AppDBContext db = new AppDBContext();

            try
            {

                var Customers = db.BillMaster.Select(p => new
                {
                    Name = p.CustomerName,
                    p.City,
                    MobileNo = p.MobileNumber,
                    p.Email,
                    }).ToList();



                dataGridView1.DataSource = Customers;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AppDBContext db=new AppDBContext();
            if (txtSearch.Text == "")
            {
                LoadCustomers();
            }
            else if (cmbSearch.SelectedItem == "Name")
            {
                try
                {

                    var Customers = db.BillMaster.Where(p => p.CustomerName.Contains(txtSearch.Text)).Select(p => new
                    {
                        Name = p.CustomerName,
                        p.City,
                        MobileNo = p.MobileNumber,
                        p.Email,
                    }).ToList();
                    dataGridView1.DataSource = Customers;


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
             else if (cmbSearch.SelectedItem == "City")
                {
                    try
                    {

                        var Customers = db.BillMaster.Where(p => p.City.Contains(txtSearch.Text)).Select(p => new
                        {
                            Name = p.CustomerName,
                            p.City,
                            MobileNo = p.MobileNumber,
                            p.Email,
                        }).ToList();
                        dataGridView1.DataSource = Customers;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading data: {ex.Message}");
                    }
                }
            else
            {
                LoadCustomers();
            }
            

        }
    }
}
