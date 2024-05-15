using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        DbSet<Student> Students { get; set; }
        DbSet<Grade> Grades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID = 1, StudentName = "Alice", DateOfBirth = new DateTime(2005, 10, 26), Height = 1.70m, Weight = 55.5f },
                new Student { StudentID = 2, StudentName = "Bob", DateOfBirth = new DateTime(2004, 08, 12), Height = 1.82m, Weight = 68.0f }
            );

            modelBuilder.Entity<Grade>().HasData(
                new Grade { GradeId = 1, GradeName = "Math", Section = "A", StudentId = 1 },
                new Grade { GradeId = 2, GradeName = "Science", Section = "B", StudentId = 2 },
                new Grade { GradeId = 3, GradeName = "English", Section = "A", StudentId = 1 },
                new Grade { GradeId = 4, GradeName = "History", Section = "B", StudentId = 2 },
                new Grade { GradeId = 5, GradeName = "Art", Section = "A", StudentId = 1 },
                new Grade { GradeId = 6, GradeName = "Music", Section = "B", StudentId = 2 },
                new Grade { GradeId = 7, GradeName = "Physical Education", Section = "A", StudentId = 1 }

            );
        }
    }
}
