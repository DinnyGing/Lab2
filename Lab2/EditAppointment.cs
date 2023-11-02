using Lab2.Entity;
using Lab2.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditAppointment : Form
    {
        Appointment appointment;

        AppointmentRepository appointmentRepository;
        ClientRepository clientRepository;
        ProcedureRepository procedureRepository;
        public EditAppointment()
        {
            InitializeComponent();
            this.clientRepository = new ClientRepository();
            this.procedureRepository = new ProcedureRepository();
            textBoxClient.Items.AddRange(clientRepository.GetAll()
                .Select(p => $"{p.ClientId}. {p.FirstName} {p.LastName}").ToList());
            textBoxProcedure.Items.AddRange(procedureRepository.GetAll()
                .Select(p => $"{p.ProcedureId}. {p.Name}").ToList());
            timePicker.Format = DateTimePickerFormat.Time;
        }
        public EditAppointment(AppointmentRepository appointmentRepository) : this()
        {
            this.appointmentRepository = appointmentRepository;
            textBoxClient.Text = clientRepository.GetAll().Select(p => $"{p.ClientId}. {p.FirstName} {p.LastName}").FirstOrDefault();
            textBoxProcedure.Text = procedureRepository.GetAll().Select(p => $"{p.ProcedureId}. {p.Name}").FirstOrDefault();
        }
        public EditAppointment(AppointmentRepository appointmentRepository, int id) : this()
        {
            this.Load += new System.EventHandler(EditAppointment_Load);
            this.appointmentRepository = appointmentRepository;
            this.appointment = appointmentRepository.GetById(id);
        }
        private void EditAppointment_Load(object sender, EventArgs e)
        {
            var client = appointmentRepository.GetClientByAppointmentId(appointment.AppointmentId);
            string clientStr = client.ClientId + ". " + client.FirstName + " " + client.LastName;
            var procedure = appointmentRepository.GetProcedureByAppointmentId(appointment.AppointmentId);
            string procedureStr = procedure.ProcedureId + ". " + procedure.Name;
            datePicker.Text = appointment.Date;
            timePicker.Text = appointment.Time;
            textBoxClient.Text = clientStr;
            textBoxProcedure.Text = procedureStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!datePicker.Equals("")
                    && !textBoxClient.Equals("")
                    && !textBoxProcedure.Equals(""))
            {

                int clientId;
                if (!int.TryParse(textBoxClient.Text.ToString().Split('.')[0], out clientId))
                    clientId = 0;

                int procedureId;
                if (!int.TryParse(textBoxProcedure.Text.ToString().Split('.')[0], out procedureId))
                    procedureId = 0;

                var client = clientRepository.GetById(clientId);
                var procedure = procedureRepository.GetById(procedureId);

                if (appointment == null)
                {
                    appointment = new Appointment()
                    {

                        Date = datePicker.Text,
                        Time = timePicker.Text,
                        Client = client,
                        Procedure = procedure
                    };
                    appointmentRepository.Create(appointment, client, procedure);
                    Appointments appointments = new Appointments();
                    appointments.Show();
                    this.Close();
                }
                else
                {
                    appointment.Date = datePicker.Text;
                    appointment.Time = timePicker.Text;
                    appointment.Client = client;
                    appointment.Procedure = procedure;
                    appointmentRepository.Update(appointment, client, procedure);
                    ShowAppointment showAppointment = new ShowAppointment(appointmentRepository, appointment.AppointmentId);
                    showAppointment.Show();
                    this.Close();
                }
            }

        }
    }
}
