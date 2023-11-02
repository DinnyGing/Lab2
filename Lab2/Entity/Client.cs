
using System.Collections.Generic;

namespace Lab2.Entity
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
