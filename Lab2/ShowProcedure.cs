using Lab2.Entity;
using Lab2.Repositories;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ShowProcedure : Form
    {
        Procedure procedure;
        ProcedureRepository procedureRepository;
        public ShowProcedure()
        {
            InitializeComponent();
        }
        public ShowProcedure(ProcedureRepository procedureRepository, int id) : this()
        {
            this.Load += new EventHandler(ShowProcedure_Load);
            this.procedureRepository = procedureRepository;
            this.procedure = procedureRepository.GetById(id);
        }
        private void ShowProcedure_Load(object sender, EventArgs e)
        {
            textBoxName.Text = procedure.Name;
            textBoxPrice.Text = procedure.Price.ToString();
            textBoxDescription.Text = procedure.Description;
            textBoxCategory.Text = procedureRepository.GetCategoryNameByProcedureId(procedure.ProcedureId);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditProcedure editProcedure = new EditProcedure(procedureRepository, procedure.ProcedureId);
            editProcedure.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            procedureRepository.Delete(procedure.ProcedureId);
            Procedures procedures = new Procedures();
            procedures.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procedures procedures = new Procedures();
            procedures.Show();
            this.Close();
        }
    }
}
