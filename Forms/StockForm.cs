using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class StockForm : Form
    {
        AppDBContext db;
        public int ProductToUpdateId;
        Product Prod;
        public StockForm()
        {
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
                    p.ProductId

                }).ToList();

               

                dataGridView1.DataSource = Products;
                dataGridView1.Columns["ProductId"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }
        public void LoadProductForUpdation(dynamic ps)
        {
            
            try
            {
                dataGridView1.DataSource = ps;
                 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }


        private void StockForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            label1.Visible = false;
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            // editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (txtSearch.Text == "")
            {
                LoadProducts();
            }
            AppDBContext db = new AppDBContext();
            if (cmbSearch.SelectedItem == "Product")
            {
                label1.Visible = false;

                try
                {

                    var Products = db.Products.Select(p => new
                    {

                        Category = p.Subcategory.Category.CategoryName,
                        Subcategory = p.Subcategory.SubcategoryName,

                        p.ProductName,
                        p.Quantity,
                        p.ProductId

                    }).Where(p => p.ProductName.Contains(txtSearch.Text)).ToList();

                    dataGridView1.DataSource = Products;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }

            }
            else if (cmbSearch.SelectedItem == "Category")
            {
                label1.Visible = false;
                try
                {

                    var Products = db.Products.Select(p => new
                    {
                        Category = p.Subcategory.Category.CategoryName,
                        Subcategory = p.Subcategory.SubcategoryName,

                        p.ProductName,
                        p.Quantity,
                        p.ProductId

                    }).Where(p => p.Category.Contains(txtSearch.Text)).ToList();

                    dataGridView1.DataSource = Products;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }


            }
            else if (cmbSearch.SelectedItem == "Subcategory")
            {
                label1.Visible= false;
                try
                {

                    var Products = db.Products.Select(p => new
                    {
                        Category = p.Subcategory.Category.CategoryName,
                        Subcategory = p.Subcategory.SubcategoryName,

                        p.ProductName,
                        p.Quantity,
                        p.ProductId

                    }).Where(p => p.Subcategory.Contains(txtSearch.Text)).ToList();

                    dataGridView1.DataSource = Products;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }

            }
            else if (cmbSearch.SelectedItem == "Quantity")
            {
                label1.Visible=true;

                if (txtSearch.Text == "" && txtSearch.Text.All(char.IsLetter))
                    LoadProducts();
                else
                {
                    try
                    {

                        var Products = db.Products.Select(p => new
                        {
                            Category = p.Subcategory.Category.CategoryName,
                            Subcategory = p.Subcategory.SubcategoryName,
                            p.ProductName,
                            p.Quantity,
                            p.ProductId

                        }).Where(p => p.Quantity <= Convert.ToDouble(txtSearch.Text)).ToList();

                        dataGridView1.DataSource = Products;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading data: {ex.Message}");
                    }


                }
            }


            else
            {
                LoadProducts();
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (cmbSearch.SelectedItem == "Quantity")
                label1.Visible = true;
            else
                label1.Visible = false;

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
                    int qty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                    string cname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Category"].Value);
                    string sname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["SubCategory"].Value);
                    string pname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value);


                    AppDBContext db = new AppDBContext();

                    if (ProdId != null)
                    {
                        UtilityClass.pid = ProdId;
                        UtilityClass.qty = qty;
                        UtilityClass.cname = cname;
                        UtilityClass.sname = sname;
                        UtilityClass.pname = pname;
                        UpdateStock updateStock = new UpdateStock();
                        updateStock.Show();
                    }
                }

            }
        }
    }
}
