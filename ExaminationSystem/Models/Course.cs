using ExaminationSystem.Data;
using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100, ErrorMessage = "Course name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Course description is required")]
        [StringLength(1000, ErrorMessage = "Course description cannot exceed 1000 characters")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string InstructorId { get; set; }
        public ApplicationUser Instructor { get; set; } // Relationship with Instructor

        public List<Question> Questions { get; set; } // One-to-Many relationship with Questions
        public List<Exam> Exams { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } // Relationship with Students
    }
}
