using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Choice
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Choice text is required")]
        [StringLength(200, ErrorMessage = "Choice text cannot exceed 200 characters")]
        public string Text { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; } // Relationship with Question

        public bool IsCorrect { get; set; }
    }
}
