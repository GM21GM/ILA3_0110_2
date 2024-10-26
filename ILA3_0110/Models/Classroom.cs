namespace ILA3_0110.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SchoolYearId { get; set; }
        public SchoolYear SchoolYear { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
