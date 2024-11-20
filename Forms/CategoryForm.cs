using Microsoft.VisualBasic;
using YashodipPly.View;
using YashodipPlyAndHardware.Data;
using YashodipPlyAndHardware.Models;
using YashodipPlyAndHardware.Forms;

namespace YashodipPlyAndHardware
{
    public partial class CategoryForm : Form
    {
        private readonly AppDBContext db;
        int CatToUpdateId;
        Category cat;
        CategoryView CategoryView;
        public CategoryForm()
        {
            InitializeComponent();
           db= new AppDBContext();
            
        }
        public CategoryForm(int CategoryId)
        {
            InitializeComponent();
            db = new AppDBContext();
            CatToUpdateId = CategoryId;
            cat = db.Categories.FirstOrDefault(c => c.CategoryId == CatToUpdateId);
            btnSave.Text = "Update";
            label8.Text = "Update Category";
            txtCategory.Text = cat.CategoryName;
            this.Show();

        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            CategoryView=new CategoryView();
            if (txtCategory.Text != "" && btnSave.Text == "Save")
            {
                Category category = new Category();
                category.CategoryName = txtCategory.Text;
                db.Categories.Add(category);
                db.SaveChanges();
              
                DialogResult res = MessageBox.Show("Category Saved Successfully...Do you want to add more??", "Yahodip ply", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    this.Close();
                    CategoryView.Show();
                }
                else
                {
                    txtCategory.Text = "";
                }

            }
            else if (txtCategory.Text != "" && btnSave.Text == "Update") {
                if (CatToUpdateId != null) { 
                    cat.CategoryName = txtCategory.Text;
                    db.SaveChanges();
                   
                    DialogResult res = MessageBox.Show("Category Updated Successfully...", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        CategoryView.LoadCategory();
                        CategoryView.Show();
                        this.Close();

                        
                    }

                    CategoryView.Show();

                }

            }
            else if(txtCategory.Text=="")
            {
                MessageBox.Show("Enter Category Name", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
