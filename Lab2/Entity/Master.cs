namespace Lab2.Entity
{
    public class Master
    {
        public int MasterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Level { get; set; }
        public int AgeInCategory { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
