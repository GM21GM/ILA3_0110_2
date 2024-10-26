using Microsoft.EntityFrameworkCore;

namespace ILA3_0110.Models
{
    public class ILA3_0110DbContext : DbContext
    {
        public ILA3_0110DbContext(DbContextOptions<ILA3_0110DbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
    }
}
