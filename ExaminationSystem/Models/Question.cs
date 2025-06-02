using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Question text is required")]
        [StringLength(500, ErrorMessage = "Question text cannot exceed 500 characters")]
        public string Text { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; } // Relationship with Course

        public List<Choice> Choices { get; set; }

        // New: Many-to-Many relationship with Exams via ExamQuestion
        public List<ExamQuestion> ExamQuestions { get; set; }
    }
}
