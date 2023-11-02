using System.Collections.Generic;

namespace Lab2.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Client> Clients { get; set; } = new List<Client>();
        public ICollection<Master> Masters { get; set; } = new List<Master>();
    }
}
