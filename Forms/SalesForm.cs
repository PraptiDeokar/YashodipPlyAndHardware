using MailKit;
using Microsoft.EntityFrameworkCore;
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
using YashodipPlyAndHardware.Models;

namespace YashodipPlyAndHardware.Forms
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void LoadSalesReport(DateTime startDate, DateTime endDate)
        {
            using (var context = new AppDBContext())
            {
                // Fetch data grouped by ProductId
                var salesReport = context.BillChild
                    .Include(bc => bc.Bill)
                    .Include(bc => bc.Product)
                    .Where(bc => bc.Bill.Date >= startDate && bc.Bill.Date <= endDate) // Filter by date range
                    .GroupBy(bc => new { bc.ProductId, bc.Product.ProductName, bc.Product.Subcategory.SubcategoryName }) // Group by Product
                    .Select(group => new BillViewModel
                    {
                        ProductName = group.Key.SubcategoryName + " " + group.Key.ProductName,
                        Quantity = group.Sum(g => g.Quantity), // Calculate total quantity for each product
                        Date = startDate, // Optional: use the filtered start date
                    })
                    .OrderBy(r => r.ProductName) // Sort by Product Name
                    .ToList();

                // Bind grouped data to DataGridView
                dataGridView1.DataSource = salesReport;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new AppDBContext())
            {
                var startDate = dateTimePicker1.Value;
                var endDate = dateTimePicker2.Value;
                if (startDate <= endDate)
                {
                    try
                    {
                        var salesSummary = context.SalesSummaries
                            .FromSqlRaw("EXEC GetSalesSummaryByDateRange @StartDate = {0}, @EndDate = {1}", startDate, endDate)
                            .ToList();

                        // Bind the result to a DataGridView or process further
                        dataGridView1.DataSource = salesSummary;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }
    }
}

