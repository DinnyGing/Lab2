
namespace Lab2.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }
        public int? ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
    }
}
