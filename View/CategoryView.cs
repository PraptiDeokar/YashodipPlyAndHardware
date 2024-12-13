using Microsoft.EntityFrameworkCore;
using YashodipPlyAndHardware;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.Forms;
using YashodipPlyAndHardware.Models;

namespace YashodipPly.View
{
    public partial class CategoryView : Form
    {
        private readonly AppDBContext db;

        Category cat;
        int categoryId;
        //int CatToUpdateId;

        public CategoryView()
        {
            InitializeComponent();
            db = new AppDBContext();
            ////    CatToUpdateId = CategoryId;
            //  //    cat = db.Categories.FirstOrDefault(c => c.CategoryId == CatToUpdateId);
            //      btnSave.Text = "Update";
            //     // label8.Text = "Update Category";
            //      txtCategory.Text = cat.CategoryName;

            LoadCategory();

        }
        public void LoadCategory()
        {


            try
            {

                var categories = db.Categories.ToList();
                dataGridView1.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

        }
        private void EditCategory(int categoryId)
        {

        }

        private void DeleteCategory(int categoryId)
        {
            var category = db.Categories.Find(categoryId);
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges(); // Save the changes to the database
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {

            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadCategory();
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
            LoadCategory();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var txt = textBox1.Text;
            if (txt != "")
            {
                try
                {
                    var categories = db.Categories.Where(c => c.CategoryName.Contains(txt)).ToList();
                    dataGridView1.DataSource = categories;
                }
                catch (Exception) { }
            }
            else
            {
                LoadCategory();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    // Get the selected row's data (e.g., ID of the record)
                    categoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CategoryId"].Value);
                    // Find the category by ID and update it as needed
                    cat = db.Categories.Find(categoryId);
                    if (cat != null)
                    {
                        txtCategory.Text = cat.CategoryName;
                        btnSave.Text = "Update";
                    }

                }
                else if (columnName == "Delete")
                {
                    try
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CategoryId"].Value) >= 0)
                        {
                            // Get the selected row's data (e.g., ID of the record)
                            int categoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CategoryId"].Value);

                            // Ask for confirmation before deleting
                            var confirmResult = MessageBox.Show("Are you sure you want to delete this item?",
                                                                "Confirm Delete", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                DeleteCategory(categoryId);
                                // Refresh the DataGridView after deletion
                                LoadCategory();
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "" && txtCategory.Text != "0" && btnSave.Text == "Save")
            {
                var categoryName = txtCategory.Text.Trim().ToLower();
                bool categoryExists = db.Categories.Any(c => c.CategoryName.Trim().ToLower() == categoryName);

                if (!categoryExists)
                {
                    var category = new Category { CategoryName = txtCategory.Text.Trim() };
                    db.Categories.Add(category);
                    db.SaveChanges();
                    MessageBox.Show("Category Saved Successfully...", "Yahodip Ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category already exists...", "Yahodip Ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                


                //DialogResult res = MessageBox.Show("Category Saved Successfully...Do you want to add more??", "Yahodip ply", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (res == DialogResult.No)
                //{
                //    txtCategory.Text = "";
                //    LoadCategory();
                //}
                //else
                //{
                txtCategory.Text = "";
                LoadCategory();
                //  }

            }
            else if (txtCategory.Text != "" && txtCategory.Text != "0" && btnSave.Text == "Update")
            {
                if (cat != null)
                {
                    cat.CategoryName = txtCategory.Text;
                    db.SaveChanges();
                    MessageBox.Show("Category Updated Successfully...", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategory();
                    txtCategory.Text = "";
                    btnSave.Text = "Save";
                }
                else
                {
                    MessageBox.Show("Select record...", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else if (txtCategory.Text == "" && txtCategory.Text == "0")
            {
                MessageBox.Show("Enter Category Name", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var txt = textBox1.Text;
            if (txt != "")
            {
                try
                {
                    var categories = db.Categories.Where(c => c.CategoryName.Contains(txt)).ToList();
                    dataGridView1.DataSource = categories;
                }
                catch (Exception) { }
            }
            else
            {
                LoadCategory();
            }
        }
    }
}
