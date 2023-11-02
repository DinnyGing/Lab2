using Lab2.Entity;
using Lab2.Repositories;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ShowClient : Form
    {
        Client client;

        ClientRepository clientRepository;
        public ShowClient()
        {
            InitializeComponent();
        }
        public ShowClient(ClientRepository clientRepository, int id) : this()
        {
            this.Load += new EventHandler(ShowClient_Load);
            this.clientRepository = clientRepository;
            this.client = clientRepository.GetById(id);
        }
        private void ShowClient_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = client.FirstName;
            textBoxLastName.Text = client.LastName;
            textBoxAge.Text = client.Age.ToString();
            textBoxGender.Text = client.Gender;
            textBoxPhone.Text = client.Phone;
            textBoxEmail.Text = client.Email;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditClient editClient = new EditClient(clientRepository, client.ClientId);
            editClient.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            clientRepository.Delete(client.ClientId);
            Clients clients = new Clients();
            clients.Show();
            this.Close();
        }
    }
}
