namespace ILA3_0110.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
    }
}
