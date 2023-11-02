using Lab2.Db;
using Lab2.DTO;
using Lab2.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Repositories
{
    public class AppointmentRepository
    {
        public List<Appointment> GetAll()
        {
            List<Appointment> appointments;
            using (ApplicationContext db = new ApplicationContext())
            {
                appointments = db.Appointments.ToList();
            }
            return appointments;
        }
        public Client GetClientByAppointmentId(int id)
        {
            Client client;
            using (ApplicationContext db = new ApplicationContext())
            {
                var appointment = db.Appointments.Include(p => p.Client).FirstOrDefault(p => p.AppointmentId == id);
                client = appointment.Client;
            }
            return client;
        }
        public Procedure GetProcedureByAppointmentId(int id)
        {
            Procedure procedure;
            using (ApplicationContext db = new ApplicationContext())
            {
                var appointment = db.Appointments.Include(p => p.Procedure).FirstOrDefault(p => p.AppointmentId == id);
                procedure = appointment.Procedure;
            }
            return procedure;
        }
        public List<AppointmentDTO> GetAllWithClientName()
        {
            List<AppointmentDTO> appointments;
            using (ApplicationContext db = new ApplicationContext())
            {
                var query = from appointment in db.Appointments
                            select new AppointmentDTO()
                            {
                                AppointmentId = appointment.AppointmentId,
                                Date = appointment.Date,
                                Time = appointment.Time,
                                ClientFirstName = appointment.Client.FirstName,
                                ClientLastName = appointment.Client.LastName,
                                ProcedureName = appointment.Procedure.Name
                            };
                appointments = query.ToList();
            }
            return appointments;
        }
        public List<AppointmentDTO> GetFilteredAppointments(Func<AppointmentDTO, bool>[] filters)
        {
            var appointments = GetAllWithClientName();

            foreach (var filter in filters)
            {
                appointments = appointments.Where(filter).ToList();
            }

            return appointments;
        }
        public Appointment GetById(int id)
        {
            Appointment appointment;
            using (ApplicationContext db = new ApplicationContext())
            {
                appointment = db.Appointments.FirstOrDefault(p => p.AppointmentId == id);
            }
            return appointment;
        }
        public void Create(Appointment appointment, Client client, Procedure procedure)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (appointment != null)
                {
                    db.Clients.Attach(client);
                    db.Procedures.Attach(procedure);
                    db.Appointments.Add(appointment);
                    db.SaveChanges();
                }
            }
        }
        public void Update(Appointment appointment, Client client, Procedure procedure)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (appointment != null)
                {
                    db.Clients.Attach(client);
                    db.Procedures.Attach(procedure);
                    db.Appointments.Update(appointment);
                    db.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var appointment = db.Appointments.Find(id);
                if (appointment != null)
                {
                    db.Appointments.Remove(appointment);
                    db.SaveChanges();
                }
            }
        }
    }
}
