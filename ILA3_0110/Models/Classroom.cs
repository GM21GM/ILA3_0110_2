using System.ComponentModel.DataAnnotations;

namespace ILA3_0110.Models
{
    public class Classroom
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int? SchoolYearId { get; set; } // Nullable machen
            public int? TeacherId { get; set; } // Nullable machen
            public SchoolYear SchoolYear { get; set; }
            public Teacher Teacher { get; set; }
            public List<Student> Students { get; set; }
        

    }


}
