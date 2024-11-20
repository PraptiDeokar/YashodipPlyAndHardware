using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.Models;

namespace YashodipPly.Forms
{
    public partial class NewBill : Form
    {
        Dictionary<int, double> dic = new Dictionary<int, double>();

        List<BillChild> billChildList = new List<BillChild>();
        double gst = 0;
        double dis = 0;
        double Total = 0;
        public NewBill()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CustomerInfo customerInfo = new CustomerInfo();
            // customerInfo.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dic.Clear();
            dataGridView1.DataSource = null; // Reset DataSource to refresh the grid
            LoadCatCombobox();
            LoadSubCatCombobox();
            LoadProducts();
            int getmaxId;
            gst = 0; dis = 0;
            AppDBContext db = new AppDBContext();
            try
            {
                if (db.BillMaster.Max(b => b.BillId) >= 0)
                    getmaxId = db.BillMaster.Max(b => b.BillId);
                else
                    getmaxId = 0;
            }
            catch (Exception ex)
            {

                getmaxId = 0;
            }
            int NewId = Convert.ToInt32(getmaxId) + 1;
            txtBillId.Text = NewId.ToString();
            addColumns();
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            // editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);

            // Adding Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            // deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Red;
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);
        }
        private void addColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Add columns for ProductName, CategoryName, SubcategoryName, etc.
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Category", DataPropertyName = "SubcategoryName" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Brand", DataPropertyName = "CategoryName" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item", DataPropertyName = "ProductName" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Quantity" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Price" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "Tot" });

        }
        private void clearAll()
        {
            txtBillId.Text = "";
            txtCustName.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtDis.Text = "";
            txtFinalTot.Text = "";
            txtGST.Text = "";
            gst = 0; dis = 0;
            txtMob.Text = "";
            txtTotal.Text = "0";
            cmbSub.Enabled = false;
            cmbProd.Enabled = false;
            dataGridView1.Columns.Clear();
        }
        private void LoadCatCombobox()
        {
            AppDBContext db = new AppDBContext();
            var categories = db.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbSub.Enabled = true;
        }

        private void LoadSubCatCombobox()
        {
            cmbSub.Enabled = true;
            AppDBContext db = new AppDBContext();
            try
            {
                int cid = Convert.ToInt32(cmbCategory.SelectedValue);
                var subcategories = db.Subcategories.Where(c => c.CategoryId == cid).ToList();
                cmbSub.DataSource = subcategories;
                cmbSub.DisplayMember = "SubcategoryName";
                cmbSub.ValueMember = "Id";
            }
            catch (Exception e)
            {

                var subcategories = db.Subcategories.ToList();
                cmbSub.DataSource = subcategories;
                cmbSub.DisplayMember = "SubcategoryName";
                cmbSub.ValueMember = "Id";

            }
            cmbProd.Enabled = true;
        }
        private void LoadProducts()
        {
            cmbProd.Enabled = true;
            AppDBContext db = new AppDBContext();
            try
            {
                int cid = Convert.ToInt32(cmbCategory.SelectedValue);
                int sid = Convert.ToInt32(cmbSub.SelectedValue);
                var products = db.Products.Where(c => c.CategoryId == cid && c.SubcategoryId == sid).ToList();

                if (products.Count > 0)
                {
                    cmbProd.DataSource = products;
                    cmbProd.DisplayMember = "ProductName";
                    cmbProd.ValueMember = "ProductId";
                }
                else
                {
                    cmbProd.Enabled = false;
                    txtPrice.Text = "";
                    cmbProd.Text = "No data";
                    //MessageBox.Show("No Items available for this category","Yashodip ply", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            catch (Exception e)
            {

                cmbProd.Enabled = false;
                txtPrice.Text = "";
                cmbProd.Text = "No data";
                //  MessageBox.Show("No Items available for this category", "Yashodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }
        private void NewBill_Load(object sender, EventArgs e)
        {

            cmbSub.Enabled = false;
            cmbProd.Enabled = false;
            txtPrice.Text = "";
            txtGST.Text = "";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubCatCombobox();
            LoadProducts();
            txtqty.Text = "0";
        }

        private void cmbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
            txtqty.Text = "0";
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            txtqty.Text = "0";
            if (cmbProd.Enabled)
            {
                try
                {
                    int pid = Convert.ToInt32(cmbProd.SelectedValue);
                    var product = db.Products.FirstOrDefault(p => p.ProductId == pid);

                    if (product != null)
                    {
                        txtPrice.Text = product.CustomerRate.ToString();
                        
                    }
                    else
                    {
                        txtPrice.Text = "0";
                      
                    }

                }
                catch (Exception)
                {

                    txtPrice.Text = "0";
                    
                }
            }
            else
            {
                txtPrice.Text = "0";
                
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double qty;
            double price;
            if (txtqty.Text == "")
            {
                qty = 0;
                txtTot.Text = "0";

            }
            else if (txtqty.Text != "" && txtPrice.Text != "")
            {
                qty = Convert.ToDouble(txtqty.Text);
                price = Convert.ToDouble(txtPrice.Text);
                double tot = price * qty;
                txtTot.Text = tot.ToString();
                // checkStock(Convert.ToInt32(cmbProd.SelectedValue),qty);
            }



        }
        private void CalculateTotal()
        {
            double grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the cell value is not null to avoid errors
                if (row.Cells[5].Value != null)
                {
                    // Try to parse the cell value as a double and add it to grandTotal
                    double rowTotal;
                    if (double.TryParse(row.Cells[5].Value.ToString(), out rowTotal))
                    {
                        grandTotal += rowTotal;
                    }
                }
            }

            // Display the calculated total in a TextBox or Label
            txtTotal.Text = grandTotal.ToString("0.00"); // Adjust format as needed
        }

        public double checkStock(int prodId)
        {
            AppDBContext db = new AppDBContext();
            Product p = db.Products.Find(prodId);
            return p.Quantity;
        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {
              try
            {

                if (dataGridView1.CurrentRow != null && btnAdd.Text == "Update")
                {
                    double stockAvail = checkStock(Convert.ToInt32(cmbProd.SelectedValue));
                    if (dic.ContainsKey(Convert.ToInt32(cmbProd.SelectedValue)))
                    {
                        stockAvail = dic[Convert.ToInt32(cmbProd.SelectedValue)];
                    }
                    if (stockAvail >= Convert.ToDouble(txtqty.Text))
                    {
                        dataGridView1.CurrentRow.Cells[0].Value = cmbCategory.Text;
                        dataGridView1.CurrentRow.Cells[1].Value = cmbSub.Text;
                        dataGridView1.CurrentRow.Cells[2].Value = cmbProd.Text;
                        dataGridView1.CurrentRow.Cells[3].Value = txtPrice.Text;
                        dataGridView1.CurrentRow.Cells[4].Value = txtqty.Text;
                        dataGridView1.CurrentRow.Cells[5].Value = txtTot.Text;
                        stockAvail -= Convert.ToDouble(txtqty.Text); 
                        if (dic.ContainsKey(Convert.ToInt32(cmbProd.SelectedValue)))
                        {
                            dic[Convert.ToInt32(cmbProd.SelectedValue)] = stockAvail;


                        }
                        else
                        {
                            dic.Add(Convert.ToInt32(cmbProd.SelectedValue), stockAvail);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Stock Available for" + cmbProd.Text + " is -" + stockAvail);
                        txtPrice.Text = "0";
                        txtqty.Text = "0";
                        txtTot.Text = "0";
                        btnAdd.Text = "+";
                    }
                    CalculateTotal();
                    txtPrice.Text = "0";
                    txtqty.Text = "0";
                    txtTot.Text = "0";
                    btnAdd.Text = "+";
                }

                if (cmbProd.Enabled && txtqty.Text != "0" && txtPrice.Text != "0" && btnAdd.Text == "+")
                {
                    double stockavail= checkStock(Convert.ToInt32(cmbProd.SelectedValue));
                    if(dic.ContainsKey(Convert.ToInt32(cmbProd.SelectedValue))){
                        stockavail = dic[Convert.ToInt32(cmbProd.SelectedValue)];
                    }
                    if (stockavail>=Convert.ToDouble(txtqty.Text))
                    {
                        dataGridView1.Rows.Add(cmbCategory.Text, cmbSub.Text, cmbProd.Text, txtPrice.Text, txtqty.Text, txtTot.Text);
                        stockavail=stockavail - Convert.ToDouble(txtqty.Text);
                        if (dic.ContainsKey(Convert.ToInt32(cmbProd.SelectedValue)))
                        {
                            dic[Convert.ToInt32(cmbProd.SelectedValue)] = stockavail;


                        }
                        else
                        {
                            dic.Add(Convert.ToInt32(cmbProd.SelectedValue), stockavail);
                        }
                        CalculateTotal();
                        txtPrice.Text = "0";
                        txtqty.Text = "0";
                        txtTot.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show($"Stock Available for {cmbProd.Text} is {stockavail}");
                       
                    }
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Enter data correctly", "Yashodip  Ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Load cell values into TextBoxes
                    cmbCategory.Text = row.Cells[0].Value.ToString();
                    cmbSub.Text = row.Cells[1].Value.ToString();
                    cmbProd.Text = row.Cells[2].Value.ToString();

                    txtPrice.Text = row.Cells[3].Value.ToString();
                    txtqty.Text = row.Cells[4].Value.ToString();
                    txtTot.Text = row.Cells[5].Value.ToString();
                    btnAdd.Text = "Update";


                }
                else if (columnName == "Delete")
                {
                    try
                    {
                        if (e.RowIndex >= 0)
                        {
                            var confirmResult = MessageBox.Show("Are you sure you want to delete this item?",
                                                            "Confirm Delete", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                                CalculateTotal();
                            }

                        }

                    }
                    catch
                    {
                        MessageBox.Show("Please select a row to remove.");
                    }


                }
            }
        }

        private void txtGST_TextChanged(object sender, EventArgs e)
        {

            if (txtGST.Text == "")
            {
                gst = 0;
            }
            else
            {
                gst = Convert.ToDouble(txtGST.Text);
            }
            CalculateFinalSum();

        }

        private void CalculateFinalSum()
        {
            double finalsum = 0;
            finalsum = gst + Convert.ToDouble(txtTotal.Text) - dis;
            txtFinalTot.Text = finalsum.ToString();

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            if (txtDis.Text == "")
            {
                dis = 0;
            }
            else
            {
                dis = Convert.ToDouble(txtDis.Text);
            }
            CalculateFinalSum();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateFinalSum();
        }
        private Boolean UpdateStock(int ProdId, double qty)
        {
            AppDBContext db = new AppDBContext();
            Product p = db.Products.Find(ProdId);
            p.Quantity = p.Quantity - qty;
            db.SaveChanges();
            return true;
            
            
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            bool clear = true;
            int billid = Convert.ToInt32(txtBillId.Text);
            Dictionary<int, double> dic = new Dictionary<int, double>();
            if (btnSave.Text == "Save" && txtFinalTot.Text != "0" && txtCustName.Text != "" && txtCity.Text != "" && txtBillId.Text != "" && dataGridView1.Rows.Count > 0)
            {
                Bill bill = new Bill();
                bill.CustomerName = txtCustName.Text;
                bill.City = txtCity.Text;
                bill.Email = txtEmail.Text;
                bill.Date = Convert.ToDateTime(dateTimePicker1.Text);
                bill.MobileNumber = txtMob.Text;
                bill.DisAmt = dis;
                bill.GstAmt = gst;
                bill.Tot = Convert.ToDouble(txtTotal.Text);
                bill.FinalTotal = Convert.ToDouble(txtFinalTot.Text);
                db.BillMaster.Add(bill);
                db.SaveChanges();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    db = new AppDBContext();
                    int idx;
                    // Check if the cell value is not null to avoid errors
                    if (row.Cells[5].Value != null && row.Cells[0] != null)
                    {
                        idx = row.Index;
                        BillChild bc = new BillChild();
                        bc.BillId = Convert.ToInt32(txtBillId.Text);
                        ProductVM productVM = new ProductVM();
                        productVM.PCategory = row.Cells[0].Value.ToString();
                        productVM.Category = db.Categories.FirstOrDefault(c => c.CategoryName == productVM.PCategory);
                        bc.CategoryId = productVM.Category.CategoryId;
                        productVM.PSubcategory = row.Cells[1].Value.ToString();
                        productVM.Subcategory = db.Subcategories.FirstOrDefault(c => c.SubcategoryName == productVM.PSubcategory);
                        bc.SubcategoryId = productVM.Subcategory.Id;
                        productVM.ProductName = row.Cells[2].Value.ToString();
                        productVM.Product = db.Products.FirstOrDefault(c => c.ProductName == productVM.ProductName && c.SubcategoryId == bc.SubcategoryId);
                        bc.ProductId = productVM.Product.ProductId;

                        bc.Price = Convert.ToDouble(row.Cells[3].Value);
                        bc.Quantity = Convert.ToDouble(row.Cells[4].Value);
                        bc.Tot = Convert.ToDouble(row.Cells[5].Value);
                                         
                            db.BillChild.Add(bc);
                            db.SaveChanges();
                            UpdateStock(bc.ProductId, bc.Quantity);
                           
                      


                    }

                }

                MessageBox.Show("Bill data saved successfully...", "Yashodip ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
            //else if (btnSave.Text == "Update" && txtFinalTot.Text != "0" && txtCustName.Text != "" && txtCity.Text != "" && txtBillId.Text != "" && dataGridView1.Rows.Count > 0)
            //{
            //    db = new AppDBContext();
            //    var childRecords = db.BillChild.Where(c => c.BillId == billid);
            //    db.BillChild.RemoveRange(childRecords);
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        db = new AppDBContext();
            //        int idx;
            //        Check if the cell value is not null to avoid errors
            //        if (row.Cells[5].Value != null && row.Cells[0] != null)
            //        {
            //            idx = row.Index;
            //            BillChild bc = new BillChild();
            //            bc.BillId = billid;
            //            ProductVM productVM = new ProductVM();
            //            productVM.PCategory = row.Cells[0].Value.ToString();
            //            productVM.Category = db.Categories.FirstOrDefault(c => c.CategoryName == productVM.PCategory);
            //            bc.CategoryId = productVM.Category.CategoryId;
            //            productVM.PSubcategory = row.Cells[1].Value.ToString();
            //            productVM.Subcategory = db.Subcategories.FirstOrDefault(c => c.SubcategoryName == productVM.PSubcategory);
            //            bc.SubcategoryId = productVM.Subcategory.Id;
            //            productVM.ProductName = row.Cells[2].Value.ToString();
            //            productVM.Product = db.Products.FirstOrDefault(c => c.ProductName == productVM.ProductName && c.SubcategoryId == bc.SubcategoryId);
            //            bc.ProductId = productVM.Product.ProductId;
            //            bc.Price = Convert.ToDouble(row.Cells[3].Value);
            //            bc.Quantity = Convert.ToDouble(row.Cells[4].Value);
            //            bc.Tot = Convert.ToDouble(row.Cells[5].Value);
            //            double astock = checkStock(bc.ProductId);
            //            if (astock >= bc.Quantity)
            //            {
            //                db.BillChild.Add(bc);
            //                UpdateStock(bc.ProductId, bc.Quantity);
            //                db.SaveChanges();
            //            }
            //            else
            //            {

            //                clear = false;
            //                dataGridView1.Rows.RemoveAt(idx);
            //                lblNote.Text = $"{productVM.Category}{productVM.Subcategory}{productVM.ProductName} :quantity={bc.Quantity}" +
            //                    $"record not added due to less stock,Available stock={astock}  ";
            //                CalculateTotal();
            //                btnSave.Text = "Update";
            //                break;
            //            }


            //        }

            //    }
            //    Bill bill = db.BillMaster.Find(billid);
            //    bill.CustomerName = txtCustName.Text;
            //    bill.City = txtCity.Text;
            //    bill.Email = txtEmail.Text;
            //    bill.Date = Convert.ToDateTime(dateTimePicker1.Text);
            //    bill.MobileNumber = txtMob.Text;
            //    bill.DisAmt = dis;
            //    bill.GstAmt = gst;
            //    CalculateTotal();
            //    bill.Tot = Convert.ToDouble(txtTotal.Text);
            //    bill.FinalTotal = Convert.ToDouble(txtFinalTot.Text);
            //    db.SaveChanges();
            
            //}
            else
            {
                MessageBox.Show("Fill data Correctly...", "Yashodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }

            
        }

        private void btnAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}