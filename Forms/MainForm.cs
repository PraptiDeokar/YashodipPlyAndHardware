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
            categoryView.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SubcategoryView subcategoryView = new SubcategoryView();
            subcategoryView.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView(db);
            productView.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewBill newBill = new NewBill();
            newBill.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StockForm stckForm = new StockForm();
            stckForm.Show();
        }
    }
}
