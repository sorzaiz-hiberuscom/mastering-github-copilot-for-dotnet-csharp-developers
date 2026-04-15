namespace Skills
{
    public class Members
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime JoinDate { get; set; }

        public Members()
        {
            JoinDate = DateTime.Now;
        }

        public Members(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            JoinDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Email: {Email}, Join Date: {JoinDate:yyyy-MM-dd}";
        }
    }
}
