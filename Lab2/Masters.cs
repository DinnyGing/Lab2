using Lab2.DTO;
using Lab2.Entity;
using Lab2.Repositories;
using Lab2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Masters : Form
    {
        MasterRepository masterRepository;
        CategoryRepository categoryRepository;
        public Masters()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Categories_Load);
            masterRepository = new MasterRepository();
            this.categoryRepository = new CategoryRepository();
            textBoxCategory.Items.AddRange(categoryRepository.GetAll().Select(p => p.Name).ToList());
            
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = masterRepository.GetAllWithCategoryName(); 
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
            int id = (int)dataGridView1["MasterId", e.RowIndex].Value;
            if (e.ColumnIndex ==
            dataGridView1.Columns["Show Request"].Index)
            {
                ShowMaster showMaster = new ShowMaster(masterRepository, id);
                showMaster.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditMaster editMaster = new EditMaster(masterRepository);
            editMaster.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var level = textBoxLevel.Text;
            var category = textBoxCategory.Text;
            if (!level.Equals("") && !category.Equals(""))
                dataGridView1.DataSource = masterRepository
                    .GetFilteredMasters(new Func<MasterDTO, bool>[] { p => p.CategoryName == category, p => p.Level == level });
            else if (!level.Equals(""))
                dataGridView1.DataSource = masterRepository
                    .GetFilteredMasters(new Func<MasterDTO, bool>[] { p => p.Level == level });
            else if (!category.Equals(""))
                dataGridView1.DataSource = masterRepository
                    .GetFilteredMasters(new Func<MasterDTO, bool>[] { p => p.CategoryName == category });
            else
                dataGridView1.DataSource = masterRepository.GetAllWithCategoryName();

        }
    }
}
