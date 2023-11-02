using Lab2.DTO;
using Lab2.Repositories;
using Lab2.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Procedures : Form
    {
        ProcedureRepository procedureRepository;
        CategoryRepository categoryRepository;
        public Procedures()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Procedures_Load);
            procedureRepository = new ProcedureRepository(); 
            this.categoryRepository = new CategoryRepository();
            textBoxCategory.Items.AddRange(categoryRepository.GetAll().Select(p => p.Name).ToList());
        }
        private void Procedures_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = procedureRepository.GetAllWithCategoryName();
            DataGridViewButtonColumn showColumn = new DataGridViewButtonColumn();
            showColumn.HeaderText = "";
            showColumn.Name = "Show Request";
            showColumn.Text = "Show";
            showColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(showColumn);
            dataGridView1.CellClick +=
            new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["Show Request"].Index) return;
            int id = (int)dataGridView1["ProcedureId", e.RowIndex].Value;
            if (e.ColumnIndex == dataGridView1.Columns["Show Request"].Index)
            {
                ShowProcedure showProcedure = new ShowProcedure(procedureRepository, id);
                showProcedure.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProcedure editProcedure = new EditProcedure(procedureRepository);
            editProcedure.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var categoryName = textBoxCategory.Text;
            
            int minPrice;
            if (!int.TryParse(textBoxMinPrice.Text, out minPrice))
                minPrice = 0;

            int maxPrice;
            if (!int.TryParse(textBoxMaxPrice.Text, out maxPrice))
                maxPrice = 2_147_483_647;

            if (!textBoxCategory.Text.Equals(""))
                dataGridView1.DataSource = procedureRepository
                    .GetFilteredProcedures(new Func<ProcedureDTO, bool>[] { p => p.CategoryName == categoryName, p => p.Price > minPrice, p => p.Price < maxPrice });
             
            else
                dataGridView1.DataSource = procedureRepository
                    .GetFilteredProcedures(new Func<ProcedureDTO, bool>[] { p => p.Price > minPrice, p => p.Price < maxPrice });
         
        }
    }
}
