using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YashodipPly.View;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.Forms;
using YashodipPlyAndHardware.Models;

namespace YashodipPlyAndHardware.View
{
    public partial class SubcategoryView : Form
    {
        private readonly AppDBContext db;
        Subcategory Subcat;
        int Subid;
        public SubcategoryView(AppDBContext _db)
        {
            InitializeComponent();
            db = _db;
            LoadSubCategory();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            AppDBContext db = new AppDBContext();
            var categories = db.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
        public void LoadSubCategory()
        {
            try
            {

                var Subcategories = db.Subcategories.Select(s => new
                {
                    s.Id,
                    CategoryName = s.Category.CategoryName, // assuming 'Category' is the navigation
                    s.SubcategoryName
                                                            //
                                                           //
                                                           // perty
                }).ToList();

                dataGridView1.DataSource = Subcategories;
                dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }
        //private void EditSubcategory(int Id)
        //{

        //}
        private void DeleteSubcategory(int Id)
        {
            var subcat = db.Subcategories.Find(Id);
            if (subcat != null)
            {
                db.Subcategories.Remove(subcat);
                db.SaveChanges(); // Save the changes to the database
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SubCategoryForm subCategoryForm = new SubCategoryForm();
            //subCategoryForm.Show();
        }

        private void SubcategoryView_Load(object sender, EventArgs e)
        {
            LoadSubCategory();
            LoadCombobox();
            LoadSubCategory();
            editDelete();

        }
        private void editDelete() {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(editButtonColumn);

            // Create and add "Delete" button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Red;
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(deleteButtonColumn);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LoadSubCategory();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AppDBContext appDBContext = new AppDBContext();
            try
            {

                var subcategories = db.Subcategories.Select(p => new
                {

                    category = p.Category.CategoryName,
                    Subcategory = p.SubcategoryName,
                    Id = p.Id

                }).Where(p => p.Subcategory.Contains(textBox1.Text)).ToList();

                dataGridView1.DataSource = subcategories;
                dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
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
                    int Subid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    Subcat = db.Subcategories.Find(Subid);
                    if (Subcat != null)
                    {
                        cmbCategory.SelectedValue = Subcat.CategoryId;
                        txtSubCategory.Text = Subcat.SubcategoryName;
                        btnSave.Text = "Update";
                    }
                }
                else if (columnName == "Delete")
                {
                    try
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value) >= 0)
                        {
                            // Get the selected row's data (e.g., ID of the record)
                            int subcategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                            // Ask for confirmation before deleting
                            var confirmResult = MessageBox.Show("Are you sure you want to delete this item?",
                                                              "Confirm Delete", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                DeleteSubcategory(subcategoryId);
                                // Refresh the DataGridView after deletion
                                LoadSubCategory();
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryView c = new CategoryView();
            c.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDBContext dBContext = new AppDBContext();
            SubcategoryView subview = new SubcategoryView(dBContext);
            if (txtSubCategory.Text != "" && txtSubCategory.Text != "0" && btnSave.Text == "Save" && cmbCategory.SelectedIndex >= 0)
            {
                Subcategory subcategory = new Subcategory();
                //  subcategory.CategoryName=cmbCategory.Text;
                subcategory.SubcategoryName = txtSubCategory.Text;

                var cid = cmbCategory.SelectedValue;
                subcategory.CategoryId = Convert.ToInt32(cid);
                db.Subcategories.Add(subcategory);
                db.SaveChanges();

                MessageBox.Show("SubCategory Saved Successfully...", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtSubCategory.Text = "";
               // cmbCategory.SelectedIndex = 0;
                dataGridView1.Columns.Clear();
                LoadSubCategory();
                editDelete();
                textBox1.Text = "";    

            }
            else if (txtSubCategory.Text != "" && btnSave.Text == "Update" && txtSubCategory.Text != "0")
            {
                if (Subcat != null)
                {
                    //Subcategory Subcat = db.Subcategories.FirstOrDefault(c => c.Id == Subid);

                    Subcat.SubcategoryName = txtSubCategory.Text;
                    //  subcat.CategoryName = cmbCategory.Text;
                    int cid = Convert.ToInt32(cmbCategory.SelectedValue);
                    Subcat.CategoryId = cid;
                    db.SaveChanges();

                    DialogResult res = MessageBox.Show("SubCategory Updated Successfully...", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Columns.Clear();
                    LoadSubCategory();
                    editDelete();
                    txtSubCategory.Text = "";
                    cmbCategory.SelectedIndex = 0;
                    btnSave.Text = "Save";
                    textBox1.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Enter Subcategory Name", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            AppDBContext appDBContext = new AppDBContext();
            try
            {

                var subcategories = db.Subcategories.Select(p => new
                {

                    category = p.Category.CategoryName,
                    Subcategory = p.SubcategoryName,
                    Id = p.Id

                }).Where(p => p.Subcategory.Contains(textBox1.Text)).ToList();

                dataGridView1.DataSource = subcategories;
                dataGridView1.Columns["Id"].Visible = false;
                editDelete();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
