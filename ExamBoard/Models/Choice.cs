using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExamBoard.Models
{
    public class Choice
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Choice text is required.")]
        [MinLength(1, ErrorMessage = "Choice text must be at least 1 character long.")]
        public string Text { get; set; }
        public bool IsCorrect { get; set; }   
        public int QuestionId { get; set; }
        
        public virtual Question Question { get; set; }
    }
}
