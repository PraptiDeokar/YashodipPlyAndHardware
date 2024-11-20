using Microsoft.EntityFrameworkCore;
using YashodipPlyAndHardware;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.Forms;
using YashodipPlyAndHardware.Models;

namespace YashodipPly.View
{
    public partial class CategoryView : Form
    {
        AppDBContext db;
        Category cat;
        public CategoryView()
        {              
            InitializeComponent();
            db = new AppDBContext();
            LoadCategory();
        }
        public void LoadCategory()
        {
             db=new AppDBContext();
            
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
            // Find the category by ID and update it as needed
             cat = db.Categories.Find(categoryId);
            if (cat != null)
            {
                CategoryForm editForm = new CategoryForm(categoryId);
                LoadCategory();
            }
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
                    int categoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CategoryId"].Value);

                    // Call your edit function or open a form to edit
                    EditCategory(categoryId);
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
    }
}
