using YashodipPlyAndHardware.Models;
using YashodipPlyAndHardware.Data;

namespace YashodipPlyAndHardware.Forms
{
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            string str = $"{UtilityClass.cname} {UtilityClass.sname} {UtilityClass.pname}";
            lblname.Text = str;
            txtcurr.Text = Convert.ToString(UtilityClass.qty);
            panel1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblmodify.Text = "+";
            panel1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblmodify.Text = "-";
            panel1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblmodify.Text = "Update To";
            panel1.Enabled = true;
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            Product prod = db.Products.FirstOrDefault(c => c.ProductId == UtilityClass.pid);
            prod.Quantity = UtilityClass.qty;
            db.SaveChanges();
            MessageBox.Show("Updated successfully...");
            txtcurr.Text = Convert.ToString(UtilityClass.qty);
            txtchange.Text = "0";
            txtup.Text = "0";
            panel1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblmodify.Text == "+")
            {
                double additionalvalue = Convert.ToDouble(txtchange.Text);
                if (Convert.ToDouble(txtchange.Text) > 0)
                    UtilityClass.qty = additionalvalue + UtilityClass.qty;
                txtup.Text = Convert.ToString(UtilityClass.qty);
            }
            else if (lblmodify.Text == "-")
            {
                double additionalvalue = Convert.ToDouble(txtchange.Text);
                if ((UtilityClass.qty - additionalvalue) >= 0)
                    UtilityClass.qty = UtilityClass.qty - additionalvalue;
                txtup.Text = Convert.ToString(UtilityClass.qty);
            }
            else
            {
                double additionalvalue = Convert.ToDouble(txtchange.Text);
                if (additionalvalue >= 0)
                    UtilityClass.qty = additionalvalue;
                txtup.Text = Convert.ToString(UtilityClass.qty);

            }
        }

        private void txtchange_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
