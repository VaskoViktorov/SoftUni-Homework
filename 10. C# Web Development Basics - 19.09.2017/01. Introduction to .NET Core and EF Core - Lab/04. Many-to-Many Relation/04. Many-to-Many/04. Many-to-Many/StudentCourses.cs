namespace _04._Many_to_Many
{
   public class StudentCourses
    {
        public int StudentId { get; set; }

        public Student Student { get; set; } = new Student();

        public int CourseId { get; set; }

        public Course Course { get; set; } = new Course();
    }
}
