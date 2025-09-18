using Microsoft.EntityFrameworkCore;

namespace ExamBoard.Models
{
    public class Exam
    {
        public int Id { get; set; }
        
        public int Score { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public bool isCompleted { get; set; } = false;
        public int NumberOfQuestions { get; set; }
        public virtual ICollection<ExamQuestion>? examQuestions { get; set; } = new List<ExamQuestion>();
    }
}
