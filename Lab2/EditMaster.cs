using Lab2.Entity;
using Lab2.Repositories;
using Lab2.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditMaster : Form
    {
        Master master;

        MasterRepository masterRepository;
        CategoryRepository categoryRepository;
        public EditMaster()
        {
            InitializeComponent();
            this.categoryRepository = new CategoryRepository();
            textBoxCategory.Items.AddRange(categoryRepository.GetAll().Select(p => p.Name).ToList());
        }
        public EditMaster(MasterRepository masterRepository) : this()
        {
            this.masterRepository = masterRepository;
            textBoxCategory.Text = categoryRepository.GetAll().Select(p => p.Name).FirstOrDefault();
        }
        public EditMaster(MasterRepository masterRepository, int id) : this()
        {
            this.Load += new EventHandler(EditMaster_Load);
            this.masterRepository = masterRepository;
            this.master = masterRepository.GetById(id);
        }
        private void EditMaster_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = master.FirstName;
            textBoxLastName.Text = master.LastName;
            textBoxAge.Text = master.Age.ToString();
            textBoxGender.Text = master.Gender;
            textBoxPhone.Text = master.Phone;
            textBoxLevel.Text = master.Level;
            textBoxAgeInCategory.Text = master.AgeInCategory.ToString();
            textBoxCategory.Text = masterRepository.GetCategoryNameByMasterId(master.MasterId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxFirstName.Equals("") && !textBoxLastName.Equals("")
                    && !textBoxAge.Equals("") && !textBoxGender.Equals("")
                    && !textBoxPhone.Equals("") && !textBoxLevel.Equals("")
                    && !textBoxAgeInCategory.Equals("") && !textBoxCategory.Equals(""))
            {
                int age;
                if (!int.TryParse(textBoxAge.Text, out age)) 
                    age = 18;

                int ageInCategory;
                if (!int.TryParse(textBoxAgeInCategory.Text, out ageInCategory))
                    ageInCategory = 0;
                
                var category = categoryRepository.GetByName(textBoxCategory.Text);
                if (master == null)
                {
                    master = new Master()
                    {

                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        Age = age,
                        Gender = textBoxGender.Text,
                        Phone = textBoxPhone.Text,
                        Level = textBoxLevel.Text,
                        AgeInCategory = ageInCategory,
                        Category = category                    
                    };
                    masterRepository.Create(master, category);
                    Masters masters = new Masters();
                    masters.Show();
                    this.Close();
                }
                else
                {
                    master.FirstName = textBoxFirstName.Text;
                    master.LastName = textBoxLastName.Text;
                    master.Age = age;
                    master.Gender = textBoxGender.Text;
                    master.Phone = textBoxPhone.Text;
                    master.Level = textBoxLevel.Text;
                    master.AgeInCategory = ageInCategory;
                    master.Category = category;
                    masterRepository.Update(master, category);
                    ShowMaster showMaster = new ShowMaster(masterRepository, master.MasterId);
                    showMaster.Show();
                    this.Close();
                }
            }
        }
    }
}
