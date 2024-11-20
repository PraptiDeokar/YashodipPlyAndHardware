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
using YashodipPlyAndHardware.Forms;
using YashodipPlyAndHardware.Models;

namespace YashodipPlyAndHardware.View
{
    public partial class SubcategoryView : Form
    {
       AppDBContext db;
        Subcategory Subcat;
        public SubcategoryView()
        {
            InitializeComponent();
            db = new AppDBContext();
            LoadSubCategory();
        }
        public void LoadSubCategory()
        {
          AppDBContext db = new AppDBContext();

            try
            {

                var Subcategories = db.Subcategories.Select(s => new
                {
                    s.Id,
                    s.SubcategoryName,
                    CategoryName = s.Category.CategoryName // assuming 'Category' is the navigation
                                                           //
                                                           //
                                                           // perty
                }).ToList();

                dataGridView1.DataSource = Subcategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }
        private void EditSubcategory(int Id)
        {
            // Find the category by ID and update it as needed
            Subcat = db.Subcategories.Find(Id);
            if (Subcat != null)
            {
                SubCategoryForm editForm = new SubCategoryForm(Id);
                editForm.Show();
                LoadSubCategory();
            }
        }
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
            SubCategoryForm subCategoryForm = new SubCategoryForm();
            subCategoryForm.Show();
        }

        private void SubcategoryView_Load(object sender, EventArgs e)
        {

            LoadSubCategory();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LoadSubCategory();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var txt = textBox1.Text;
            if (txt != "")
            {
                try
                {
                    var subcategories = db.Subcategories.Where(c => c.SubcategoryName.Contains(txt)).ToList();
                    dataGridView1.DataSource = subcategories;
                }
                catch (Exception) { }
            }
            else
            {
                LoadSubCategory();
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
                    int subcategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    // Call your edit function or open a form to edit
                     EditSubcategory(subcategoryId);
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
            }
        } 
