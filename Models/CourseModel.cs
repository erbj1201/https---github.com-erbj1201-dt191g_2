using System.ComponentModel.DataAnnotations;
namespace mvc.Models;
//Class for model Courses
    public class CourseModel{
        public int Id {get; set;}
        [Required]
        public string? CourseCode {get; set;}
        [Required]
        public string? CourseName {get; set;}
        [Required]
        public string? CourseLangKnow {get; set;}
    }
