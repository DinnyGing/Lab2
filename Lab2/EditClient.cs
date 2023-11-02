using Lab2.Entity;
using Lab2.Repositories;
using Lab2.Services;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditClient : Form
    {
        Client client;

        ClientRepository clientRepository;
        public EditClient()
        {
            InitializeComponent();
        }
        public EditClient(ClientRepository clientRepository) : this()
        {
            this.clientRepository = clientRepository;
        }
        public EditClient(ClientRepository clientRepository, int id) : this()
        {
            this.Load += new EventHandler(EditClient_Load);
            this.clientRepository = clientRepository;
            this.client = clientRepository.GetById(id);
        }
        private void EditClient_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = client.FirstName;
            textBoxLastName.Text = client.LastName;
            textBoxAge.Text = client.Age.ToString();
            textBoxGender.Text = client.Gender;
            textBoxPhone.Text = client.Phone;
            textBoxEmail.Text = client.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxFirstName.Equals("")
                    && !textBoxLastName.Equals("")
                    && !textBoxAge.Equals("")
                    && !textBoxGender.Equals("")
                    && !textBoxPhone.Equals("")
                    && !textBoxEmail.Equals(""))
            {
                int age;
                if (!int.TryParse(textBoxAge.Text, out age))
                    age = 18;
                if (client == null)
                {
                    client = new Client()
                    {

                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        Age = age,
                        Gender = textBoxGender.Text,
                        Phone = textBoxPhone.Text,
                        Email = textBoxEmail.Text
                    };
                    clientRepository.Create(client);
                    Clients clients = new Clients();
                    clients.Show();
                    this.Close();
                }
                else
                {
                    client.FirstName = textBoxFirstName.Text;
                    client.LastName = textBoxLastName.Text;
                    client.Age = age;
                    client.Gender = textBoxGender.Text;
                    client.Phone = textBoxPhone.Text;
                    client.Email = textBoxEmail.Text;
                    clientRepository.Update(client);
                    ShowClient showClient = new ShowClient(clientRepository, client.ClientId);
                    showClient.Show();
                    this.Close();
                }
            }
        }
    }
}
