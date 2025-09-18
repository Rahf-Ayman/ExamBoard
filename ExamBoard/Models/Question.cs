using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ExamBoard.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "this text is required.")]
        [MinLength(1, ErrorMessage = "this text must be at least 5 character long.")]
        public string Text { get; set; }
        public int RandomFlag { get; set; } = new Random().Next(0, 100);
        public virtual ICollection<ExamQuestion>? examQuestions { get; set; } = new List<ExamQuestion>();

        public virtual List<Choice>? Choices { get; set; } = new List<Choice> ();

        
    }
}