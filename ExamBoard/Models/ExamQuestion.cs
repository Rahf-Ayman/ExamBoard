using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExamBoard.Models
{
    [PrimaryKey(nameof(ExamId) ,nameof(QuestionId))]
    public class ExamQuestion
    {
        [Key]
        public int ExamId { get; set; }

        [Key]
        public int QuestionId { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Question Question { get; set; }

        [Required(ErrorMessage = "You must select an answer.")]
        public int ChoiceId { get; set; }
    }
}
