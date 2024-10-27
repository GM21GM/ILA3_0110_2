namespace ILA3_0110.Models
{
    public class SchoolYear
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();  // Optional, um die Beziehung zu ermöglichen
    }

}
