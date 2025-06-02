using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Exam
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Exam name is required")]
        [StringLength(100, ErrorMessage = "Exam name cannot exceed 100 characters")]
        public string Name { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; } // Relationship with Course

        public List<StudentExam> StudentExams { get; set; }

        // New: Many-to-Many relationship with Questions
        public List<ExamQuestion> ExamQuestions { get; set; }
    }
}
