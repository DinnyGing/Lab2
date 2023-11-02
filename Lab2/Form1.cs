using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masters masters = new Masters();
            masters.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Procedures procedures = new Procedures();
            procedures.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
        }
    }
}
