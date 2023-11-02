using System.Collections.Generic;

namespace Lab2.Entity
{
    public class Procedure
    {
        public int ProcedureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
