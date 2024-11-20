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
using YashodipPlyAndHardware.Models;
using YashodipPlyAndHardware.View;

namespace YashodipPlyAndHardware.Forms
{
    public partial class SubCategoryForm : Form
    {
        AppDBContext db;
        public int SubcatToUpdateId;
        Subcategory subcat;
        SubcategoryView subcategoryView;
        public SubCategoryForm()
        {
            InitializeComponent();
            db= new AppDBContext();
        }
        public SubCategoryForm(int Id)
        {
            InitializeComponent();
            SubcatToUpdateId=Id;
           AppDBContext db=new AppDBContext();
            subcat = db.Subcategories.FirstOrDefault(c => c.Id == SubcatToUpdateId);

            btnSave.Text = "Update";
            label8.Text = "Update Category";
            txtSubCategory.Text = subcat.SubcategoryName;
         //   cmbCategory.Text = subcat.CategoryName;
           // this.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SubcategoryView subview = new SubcategoryView();
            if (txtSubCategory.Text != "" && btnSave.Text == "Save" && cmbCategory.SelectedIndex>=0)
            {
                Subcategory subcategory = new Subcategory();
              //  subcategory.CategoryName=cmbCategory.Text;
                subcategory.SubcategoryName=txtSubCategory.Text;
              
                var cid=cmbCategory.SelectedValue;
                subcategory.CategoryId = Convert.ToInt32(cid);
                db.Subcategories.Add(subcategory);
                db.SaveChanges();

                DialogResult res = MessageBox.Show("SubCategory Saved Successfully...Do you want to add more??", "Yahodip ply", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    this.Close();
                  //  subview.Show();
                }
                else
                {
                    txtSubCategory.Text = "";
                    cmbCategory.SelectedIndex = 0;
                }

            }
            else if (txtSubCategory.Text != "" && btnSave.Text == "Update")
            {
                if (SubcatToUpdateId != null)
                {
                   Subcategory subcat = db.Subcategories.FirstOrDefault(c => c.Id == SubcatToUpdateId);

                    subcat.SubcategoryName = txtSubCategory.Text;
                  //  subcat.CategoryName = cmbCategory.Text;
                    int cid = Convert.ToInt32(cmbCategory.SelectedValue);
                    subcat.CategoryId=cid;    
                    db.SaveChanges();

                    DialogResult res = MessageBox.Show("SubCategory Updated Successfully...", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        subview.LoadSubCategory();
                       // subview.Show();
                        this.Close();


                    }

                  //  subview.Show();

                }

            }
            else if (txtSubCategory.Text == "")
            {
                MessageBox.Show("Enter Category Name", "Yahodip ply", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void LoadCombobox()
        {
            db = new AppDBContext();
            var categories = db.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
        private void SubCategoryForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm =new CategoryForm();
            categoryForm.ShowDialog();
            LoadCombobox();
        }
    }
}
