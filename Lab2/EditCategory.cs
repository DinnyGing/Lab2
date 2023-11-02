using Lab2.Entity;
using Lab2.Services;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditCategory : Form
    {
        Category category;

        CategoryRepository categoryRepository;
        public EditCategory()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(EditCategory_Load);
        }
        public EditCategory(CategoryRepository categoryRepository, int id) : this()
        {
            this.categoryRepository = categoryRepository;
            this.category = categoryRepository.GetById(id);
        }
        private void EditCategory_Load(object sender, EventArgs e)
        {
            textBox1.Text = category.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            category.Name = textBox1.Text;
            categoryRepository.Update(category);
            Categories categories = new Categories();
            categories.Show();
            this.Close();
        }
    }
}
