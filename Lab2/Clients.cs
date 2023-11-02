using Lab2.Repositories;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Clients : Form
    {
        ClientRepository clientRepository;
        public Clients()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Clients_Load);
            clientRepository = new ClientRepository();
        }
        private void Clients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientRepository.GetAllWithOutAppointment();
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
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["Show Request"].Index) 
                return;

            int id = (int)dataGridView1[0, e.RowIndex].Value;

            if (e.ColumnIndex == dataGridView1.Columns["Show Request"].Index)
            {
                ShowClient showClient = new ShowClient(clientRepository, id);
                showClient.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditClient editClient = new EditClient(clientRepository);
            editClient.Show();
            this.Close();
        }
    }
}
