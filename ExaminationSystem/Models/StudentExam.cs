using ExaminationSystem.Data;

namespace ExaminationSystem.Models
{
    public class StudentExam
    {
       
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; } // Relationship with Student

        public int ExamId { get; set; }
        public Exam Exam { get; set; } // Relationship with Exam

        public int? Score { get; set; }
    }
}
