using Lab2.Entity;
using Lab2.Repositories;
using Lab2.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditProcedure : Form
    {
        Procedure procedure;

        ProcedureRepository procedureRepository;
        CategoryRepository categoryRepository;
        public EditProcedure()
        {
            InitializeComponent();
            this.categoryRepository = new CategoryRepository();
            textBoxCategory.Items.AddRange(categoryRepository.GetAll().Select(p => p.Name).ToList());
        }
        public EditProcedure(ProcedureRepository procedureRepository) : this()
        {
            this.procedureRepository = procedureRepository;
            textBoxCategory.Text = categoryRepository.GetAll().Select(p => p.Name).FirstOrDefault();
        }
        public EditProcedure(ProcedureRepository procedureRepository, int id) : this()
        {
            this.Load += new EventHandler(EditProcedure_Load);
            this.procedureRepository = procedureRepository;
            this.procedure = procedureRepository.GetById(id);
        }
        private void EditProcedure_Load(object sender, EventArgs e)
        {
            textBoxName.Text = procedure.Name;
            textBoxPrice.Text = procedure.Price.ToString();
            textBoxDescription.Text = procedure.Description;
            textBoxCategory.Text = procedureRepository.GetCategoryNameByProcedureId(procedure.ProcedureId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxName.Equals("") && !textBoxPrice.Equals("")
                    && !textBoxCategory.Equals("") && !textBoxDescription.Equals(""))
            {
                int price;
                if (!int.TryParse(textBoxPrice.Text, out price))
                    price = 0;
                
                var category = categoryRepository.GetByName(textBoxCategory.Text);
                if (procedure == null)
                {
                    procedure = new Procedure()
                    {

                        Name = textBoxName.Text,
                        Price = price,
                        Description = textBoxDescription.Text,
                        Category = category
                    };
                    procedureRepository.Create(procedure, category);
                    Procedures procedures = new Procedures();
                    procedures.Show();
                    this.Close();
                }
                else
                {
                    procedure.Name = textBoxName.Text;
                    procedure.Price = price;
                    procedure.Description = textBoxDescription.Text;
                    procedure.Category = category;
                    procedureRepository.Update(procedure, category);
                    ShowProcedure showProcedure = new ShowProcedure(procedureRepository, procedure.ProcedureId);
                    showProcedure.Show();
                    this.Close();
                }
            }

        }
    }
}
