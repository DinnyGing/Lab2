namespace Lab2.DTO
{
    public class AppointmentDTO
    {
        public int AppointmentId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string ClientFirstName {  get; set; }
        public string ClientLastName {  get; set; }
        public string ProcedureName {  get; set; }
    }
}
