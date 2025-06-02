using ExaminationSystem.Data;

namespace ExaminationSystem.Models
{
    public class StudentCourse
    {
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; } // Relationship with Student

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
