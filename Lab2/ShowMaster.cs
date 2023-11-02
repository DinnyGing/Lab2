using Lab2.Entity;
using Lab2.Repositories;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ShowMaster : Form
    {
        Master master;

        MasterRepository masterRepository;
        public ShowMaster()
        {
            InitializeComponent();
        }
        public ShowMaster(MasterRepository masterRepository, int id) : this()
        {
            this.Load += new EventHandler(ShowMaster_Load);
            this.masterRepository = masterRepository;
            this.master = masterRepository.GetById(id);
        }
        private void ShowMaster_Load(object sender, EventArgs e)
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

        private void editButton_Click(object sender, EventArgs e)
        {
            EditMaster editMaster = new EditMaster(masterRepository, master.MasterId);
            editMaster.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masters masters = new Masters();
            masters.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            masterRepository.Delete(master.MasterId);
            Masters masters = new Masters();
            masters.Show();
            this.Close();
        }
    }
}
