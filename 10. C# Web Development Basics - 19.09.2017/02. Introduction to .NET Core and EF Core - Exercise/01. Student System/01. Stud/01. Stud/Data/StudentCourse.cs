﻿namespace _01._Stud.Data
{
    public class StudentCourse
    {       
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
