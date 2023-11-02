using Lab2.Entity;
using Lab2.Services;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Categories : Form
    {
        CategoryRepository categoryRepository;
        public Categories()
        {
            InitializeComponent();
            this.Load += new EventHandler(Categories_Load);
            categoryRepository = new CategoryRepository();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryRepository.GetAllWithOutList();

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "";
            editColumn.Name = "Edit Request";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "Delete Request";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(editColumn);
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != dataGridView1.Columns["Edit Request"].Index
            && e.ColumnIndex != dataGridView1.Columns["Delete Request"].Index)) return;
            int id = (int)dataGridView1["CategoryId", e.RowIndex].Value;
            if (e.ColumnIndex == dataGridView1.Columns["Edit Request"].Index)
            {
                EditCategory editCategory = new EditCategory(categoryRepository, id);
                editCategory.Show();
                this.Close();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete Request"].Index)
            {
                categoryRepository.Delete(id);
                Categories_Load(sender, e);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            if (name != null)
            {
                var category = categoryRepository.GetByName(name);
                if (category == null)
                {
                    categoryRepository.Create(new Category { Name = name });
                    dataGridView1.DataSource = categoryRepository.GetAllWithOutList();
                }
            }
        }
    }
}
