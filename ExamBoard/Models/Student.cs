using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ExamBoard.Models
{
    [Index(nameof(Email), IsUnique = true, Name = "IX_Email")]
    public class Student
    {
        public int Id { get; set; }

        [MinLength(3,ErrorMessage = "Name must be at least 3 character long.")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender is Required.")]
        public Gender gender { get; set; } = Gender.Male;

        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }
        public virtual ICollection<Exam>? Exams { get; set; } = new List<Exam>();


    }
}
