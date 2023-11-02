using Lab2.Entity;
using Lab2.Repositories;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ShowAppointment : Form
    {
        Appointment appointment;

        AppointmentRepository appointmentRepository;
        public ShowAppointment()
        {
            InitializeComponent();
        }
        public ShowAppointment(AppointmentRepository appointmentRepository, int id) : this()
        {
            this.Load += new EventHandler(ShowAppointment_Load);
            this.appointmentRepository = appointmentRepository;
            this.appointment = appointmentRepository.GetById(id);
        }
        private void ShowAppointment_Load(object sender, EventArgs e)
        {
            var client = appointmentRepository.GetClientByAppointmentId(appointment.AppointmentId);
            string clientStr = client.ClientId + ". " + client.FirstName + " " + client.LastName;
            var procedure = appointmentRepository.GetProcedureByAppointmentId(appointment.AppointmentId);
            string procedureStr = procedure.ProcedureId + ". " + procedure.Name;
            textBoxDate.Text = appointment.Date;
            textBoxTime.Text = appointment.Time;
            textBoxClient.Text = clientStr;
            textBoxProcedure.Text = procedureStr;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditAppointment editAppointment = new EditAppointment(appointmentRepository, appointment.AppointmentId);
            editAppointment.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            appointmentRepository.Delete(appointment.AppointmentId);
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Close();
        }
    }
}
