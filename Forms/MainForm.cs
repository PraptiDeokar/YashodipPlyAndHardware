using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YashodipPly.Forms;
using YashodipPly.View;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.View;

namespace YashodipPlyAndHardware.Forms
{
    public partial class MainForm : Form
    {
        AppDBContext db;
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CategoryView categoryView = new CategoryView();
            OpenChildForm(categoryView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppDBContext dBContext = new AppDBContext();
            SubcategoryView subcategoryView = new SubcategoryView(dBContext);
            OpenChildForm(subcategoryView);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView(db);
            OpenChildForm(productView);
        }
        private void OpenChildForm(Form childForm)
        {
            // Close any existing form in the panel
            if (panel4.Controls.Count > 0)
                panel4.Controls[0].Dispose();

            // Set child form properties
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add child form to panel
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;

            // Show the child form
            childForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            NewBill newBill = new NewBill();

            OpenChildForm(newBill);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StockForm stckForm = new StockForm();
            OpenChildForm(stckForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BillingDetails bd = new BillingDetails();
            OpenChildForm(bd);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

            linkLabel1.Text = "Akshay Devkar";
            lblmarque.Text = "Stock: AAPL $150 ↑ | MSFT $310 ↓ | GOOG $2800 ↑"; // Example stock info
            getstock();
            lblmarque.Left = this.Width; // Start off-screen
            timer1.Start();
        }
        public void getstock()
        {
            AppDBContext db = new AppDBContext();

            try
            {

                var Stock = db.Products.Where(p => p.Quantity <= 5).Select(p => new
                {
                    Category = p.Subcategory.Category.CategoryName,
                    Subcategory = p.Subcategory.SubcategoryName,
                    p.ProductName,
                    p.Quantity,
                    p.ProductId

                }).ToList();
                lblmarque.Text = "Stock Updates:: " + string.Join(" | ", Stock.Select(s => $"{s.Subcategory} {s.ProductName} - {s.Quantity}"));


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblmarque.Left -= 2; // Move text left
            if (lblmarque.Right < 0) // Reset position when it moves out of view
                lblmarque.Left = this.Width;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails();
            OpenChildForm(cd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesForm sf=new SalesForm();
            OpenChildForm(sf);
        }
    }
}
