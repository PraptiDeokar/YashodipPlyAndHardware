using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.Forms;
using YashodipPlyAndHardware.Models;
using YashodipPly.View;

namespace YashodipPlyAndHardware.View
{
    public partial class ProductView : Form
    {
        AppDBContext db;
        public int ProductToUpdateId;
        Product Prod;

        public ProductView(AppDBContext _db)
        {
            this.db = _db;
            InitializeComponent();
        }

        public void LoadProducts()
        {
            AppDBContext db = new AppDBContext();

            try
            {

                var Products = db.Products.Select(p => new
                {
                    Category = p.Subcategory.Category.CategoryName,
                    Subcategory = p.Subcategory.SubcategoryName,
                    p.ProductName,
                    p.Quantity,
                    p.CustomerRate,
                    p.Rate,
                    p.Description,
                    p.ProductId
                }).ToList();

                dataGridView1.DataSource = Products;
                dataGridView1.Columns["ProductId"].Visible = false;
                dataGridView1.Columns["Description"].Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
           
        }
        private void LoadCatCombobox()
        {
            AppDBContext db = new AppDBContext();
            var categories = db.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

        }
        private void LoadSubCatCombobox()
        {
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

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Add your painting logic here, or leave it empty if not needed
        }
        private void editdelete()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);

            // Adding Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Red;
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);
        }
        private  void ProductView_Load(object sender, EventArgs e)
        {
           
                LoadProducts();
                editdelete();
            dataGridView1.CellClick += dataGridView1_CellClick;

            LoadCatCombobox();
            cmbSub.Enabled = false;
            txtQty.Text = "0";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSub.Enabled = true;
            LoadSubCatCombobox();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            SubcategoryView subview = new SubcategoryView(db);
            if (txtProduct.Text != "" && txtRate.Text != "" && txtCustRate.Text != "" && txtQty.Text != "" && cmbCategory.SelectedIndex >= 0)
            {
                if (btnSave.Text == "Save")
                {
                    Product product = new Product();
                    product.ProductName = txtProduct.Text;
                    product.Rate = Convert.ToDouble(txtRate.Text);
                    product.CustomerRate = Convert.ToDouble(txtCustRate.Text);
                    product.Quantity = Convert.ToDouble(txtQty.Text);
                    product.Description = txtDes.Text;


                    try
                    {

                        product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                        if (cmbSub.Enabled)
                            product.SubcategoryId = Convert.ToInt32(cmbSub.SelectedValue);
                        else
                        {
                            MessageBox.Show("Select Category and Subcategory", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cmbSub.Enabled = true;
                        }


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Select Category and Subcategory", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbSub.Enabled = true;
                    }




                    db.Products.Add(product);
                    db.SaveChanges();

                   MessageBox.Show("Product Saved Successfully", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Question);
                   dataGridView1.Columns.Clear();
                        LoadProducts();
                    editdelete();
                        txtProduct.Clear();
                        txtRate.Clear();
                        txtCustRate.Clear();
                        txtQty.Clear();
                        txtDes.Clear();
                      //  cmbCategory.SelectedIndex = 0;
                        cmbSub.Enabled = false;
                    txtSearch.Text = "";

                }

                else if (btnSave.Text == "Update")
                {
                    if (ProductToUpdateId != null)
                    {
                        Product prod = db.Products.FirstOrDefault(c => c.ProductId == ProductToUpdateId);

                        //txtProduct.Text = prod.ProductName;
                        //txtRate.Text = prod.Rate.ToString();
                        //txtCustRate.Text = prod.CustomerRate.ToString();
                        //txtQty.Text = prod.Quantity.ToString();
                        //txtDes.Text = prod.Description;
                        //cmbSub.Text = prod.Subcategory.SubcategoryName;
                        //cmbCategory.Text = prod.Subcategory.Category.CategoryName;

                        //-------------------------------------------------------

                        prod.ProductName = txtProduct.Text;
                        prod.Rate = Convert.ToDouble(txtRate.Text);
                        prod.CustomerRate = Convert.ToDouble(txtCustRate.Text);
                        prod.Quantity = Convert.ToDouble(txtQty.Text);
                        prod.Description = txtDes.Text;


                        try
                        {

                            prod.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                            if (cmbSub.Enabled)
                                prod.SubcategoryId = Convert.ToInt32(cmbSub.SelectedValue);
                            else
                            {
                                // MessageBox.Show("Select Category and Subcategory", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cmbSub.Enabled = true;
                            }


                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("Select Category and Subcategory", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //cmbSub.Enabled = true;
                        }



                        db.SaveChanges();

                        MessageBox.Show("Product Updated Successfully...", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      dataGridView1.Columns.Clear();
                            LoadProducts();
                        editdelete();
                            txtProduct.Clear();
                            txtRate.Clear();
                            txtCustRate.Clear();
                            txtQty.Clear();
                            txtDes.Clear();
                            cmbCategory.SelectedIndex = 0;
                            cmbSub.Enabled = false;
                        txtSearch.Text = "";

                        
                    }
                    btnSave.Text = "Save";
                    dataGridView1.Columns.Clear();
                    LoadProducts();
                    editdelete();
                    txtProduct.Clear();
                    txtRate.Clear();
                    txtCustRate.Clear();
                    txtQty.Clear();
                    txtDes.Clear();
                    cmbCategory.SelectedIndex = 0;
                    cmbSub.Enabled = false;

                }
                else if (txtProduct.Text == "")
                {
                    MessageBox.Show("Enter Category Name", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void DeleteProduct(int Id)
        {
            AppDBContext db = new AppDBContext();

            var prod = db.Products.Find(Id);
            if (prod != null)
            {
                db.Products.Remove(prod);
                db.SaveChanges(); // Save the changes to the database
            }
        }
        private void EditProduct(int Id)
        {
            AppDBContext db = new AppDBContext();

            if (Id != null)
            {
                ProductToUpdateId = Id;
                Product prod = db.Products.Include(p => p.Subcategory.Category).FirstOrDefault(p => p.ProductId == Id);

                txtProduct.Text = prod.ProductName.ToString();
                txtRate.Text = prod.Rate.ToString();
                txtCustRate.Text = prod.CustomerRate.ToString();
                txtQty.Text = prod.Quantity.ToString();
                txtDes.Text = prod.Description.ToString();
                cmbSub.Text = prod.Subcategory.SubcategoryName;
                cmbCategory.Text = prod.Subcategory.Category.CategoryName;
                btnSave.Text = "Update";
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    // Get the selected row's data (e.g., ID of the record)
                    int ProdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);

                    // Call your edit function or open a form to edit
                    EditProduct(ProdId);
                }
                else if (columnName == "Delete")
                {
                    try
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value) >= 0)
                        {
                            // Get the selected row's data (e.g., ID of the record)
                            int ProdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);

                            // Ask for confirmation before deleting
                            var confirmResult = MessageBox.Show("Are you sure you want to delete this item?",
                                                              "Confirm Delete", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                DeleteProduct(ProdId);
                                // Refresh the DataGridView after deletion
                                LoadProducts();
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            AppDBContext db = new AppDBContext();
            if (cmbSearch.SelectedItem == "Product")
            {

                try
                {

                    var Products = db.Products.Select(p => new
                    {


                        Subcategory = p.Subcategory.SubcategoryName,
                        Category = p.Subcategory.Category.CategoryName,
                        p.ProductName,
                        p.Rate,
                        p.CustomerRate,
                        p.Quantity,
                        p.Description,
                        p.ProductId

                    }).Where(p => p.ProductName.Contains(txtSearch.Text)).ToList();

                    dataGridView1.DataSource = Products;
                    dataGridView1.Columns["ProductId"].Visible = false;
                     editdelete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }

            }
            else if (cmbSearch.SelectedItem == "Category")
            {
                try
                {

                    var Products = db.Products.Select(p => new
                    {
                        Subcategory = p.Subcategory.SubcategoryName,
                        Category = p.Subcategory.Category.CategoryName,
                        p.ProductName,
                        p.Rate,
                        p.CustomerRate,
                        p.Quantity,

                        p.Description,
                        p.ProductId

                    }).Where(p => p.Category.Contains(txtSearch.Text)).ToList();

                    dataGridView1.DataSource = Products;
                    dataGridView1.Columns["ProductId"].Visible = false;
                    editdelete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }


            }
            else if (cmbSearch.SelectedItem == "Subcategory")
            {
                try
                {

                    var Products = db.Products.Select(p => new
                    {
                        Subcategory = p.Subcategory.SubcategoryName,
                        Category = p.Subcategory.Category.CategoryName,
                        p.ProductName,
                        p.Rate,
                        p.CustomerRate,
                        p.Quantity,

                        p.Description,
                        p.ProductId

                    }).Where(p => p.Subcategory.Contains(txtSearch.Text)).ToList();

                    dataGridView1.DataSource = Products;
                    dataGridView1.Columns["ProductId"].Visible = false;
                    editdelete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }

            }
            else
            {
                LoadProducts();
                editdelete();
                txtProduct.Clear();
                txtRate.Clear();
                txtCustRate.Clear();
                txtQty.Clear();
                txtDes.Clear();
                cmbCategory.SelectedIndex = 0;
                cmbSub.Enabled = false;
            }
            

        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCustRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryView cv = new CategoryView();
            cv.Show();
            LoadCatCombobox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppDBContext appDBContext = new AppDBContext();
            SubcategoryView sv = new SubcategoryView(appDBContext);
            sv.Show();
            LoadSubCatCombobox();
        }

        private void cmbSub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

