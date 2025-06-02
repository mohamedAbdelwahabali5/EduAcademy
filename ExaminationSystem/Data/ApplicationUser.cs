using ExaminationSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace ExaminationSystem.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string? Specialization { get; set; } 
        public string? StudentIdNumber { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } // Relationship with Courses
        public List<StudentExam> StudentExams { get; set; }
    }

}
