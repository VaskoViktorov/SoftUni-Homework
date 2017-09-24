using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace _04._Many_to_Many
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; } = new List<StudentCourses>();
    }
}
