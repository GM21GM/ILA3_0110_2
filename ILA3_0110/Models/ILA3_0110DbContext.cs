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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>()
                .HasMany(c => c.Students)
                .WithOne()
                .HasForeignKey(s => s.ClassroomId)
                .OnDelete(DeleteBehavior.SetNull);  // Optional: Wenn ein Klassenzimmer gelöscht wird, werden Schüler nicht gelöscht

            modelBuilder.Entity<Classroom>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Classrooms)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);  // Optional: Wenn ein Lehrer gelöscht wird, bleiben die Klassenzimmer erhalten

            modelBuilder.Entity<Classroom>()
                .HasOne(c => c.SchoolYear)
                .WithMany(sy => sy.Classrooms)
                .HasForeignKey(c => c.SchoolYearId)
                .OnDelete(DeleteBehavior.SetNull);  // Optional: Wenn ein Schuljahr gelöscht wird, bleiben die Klassenzimmer erhalten
        }

    }
}

