using Microsoft.EntityFrameworkCore;
using ExamBoard.Models;

namespace ExamBoard.Data
{
    public class ExamBoardContext : DbContext
    {
        public ExamBoardContext()
        {
        }
        public ExamBoardContext(DbContextOptions<ExamBoardContext> options) : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=.;Database=ExamBoardDB;Trusted_Connection=True;TrustServerCertificate=True;")
                    .UseLazyLoadingProxies();
            }
        }
    }
}
