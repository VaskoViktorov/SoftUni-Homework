using System;
using System.Collections.Generic;
using System.Linq;
using BashSoft.Contracts;
using BashSoft.Exceptions;

namespace BashSoft.Models
{
    public class SoftUniStudent : IStudent
    {
        private string username;
        private Dictionary<string, ICourse> enrolledCourses;
        private Dictionary<string, double> marksByCourseName;

        public SoftUniStudent(string username)
        {
            this.Username = username;
            this.enrolledCourses = new Dictionary<string, ICourse>();
            this.marksByCourseName = new Dictionary<string, double>();
        }


        public string Username
        {
            get { return this.username; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException(nameof(this.username));
                }
               this.username = value;
            }
        }

        public IReadOnlyDictionary<string, ICourse> EnrolledCourses
        {
            get { return enrolledCourses; }
        }

        public IReadOnlyDictionary<string, double> MarksByCourseName
        {
            get { return marksByCourseName; }
        }

        public void EnrollInCourse(ICourse softUniCourse)
        {
            if (this.enrolledCourses.ContainsKey(softUniCourse.Name))
            {
                throw new DuplicateEntryInStructureException(this.username, softUniCourse.Name);
            }
            this.enrolledCourses.Add(softUniCourse.Name, softUniCourse);
        }

        public void SetMarkOnCourse(string courseName, params int[] scores)
        {
            if (!this.enrolledCourses.ContainsKey(courseName))
            {
                throw new CourseNotFoundException();
            }

            if (scores.Length > SoftUniCourse.NumberOfTasksOnExam)
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumberOfScores);
            }

            this.marksByCourseName.Add(courseName, CalculateMark(scores));
        }

        private double CalculateMark(int[] scores)
        {
            double persentageOfSolvedExam = scores.Sum() /
                                            (double) (SoftUniCourse.NumberOfTasksOnExam * SoftUniCourse.MaxScoreOnExamTask);
            double mark = persentageOfSolvedExam * 4 + 2;

            return mark;
        }

        public int CompareTo(SoftUniStudent other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(this.username, other.username, StringComparison.Ordinal);
        }

        public int CompareTo(IStudent other) => this.Username.CompareTo(other.Username);


        public override string ToString() => this.Username;
    }
}
