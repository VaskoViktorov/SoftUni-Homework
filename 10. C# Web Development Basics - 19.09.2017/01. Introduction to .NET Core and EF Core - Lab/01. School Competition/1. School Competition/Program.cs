using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._School_Competition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> studentCourse = new Dictionary<string, SortedSet<string>>();
            Dictionary<string, int> studentPoints = new Dictionary<string, int>();
            string name;
            string course;
            string points;

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END")
                {
                    break;
                }

                name = input[0];
                course = input[1];
                points = input[2];

                if (!studentCourse.ContainsKey(name))
                {
                    studentCourse.Add(name, new SortedSet<string>());
                }

                studentCourse[name].Add(course);

                if (!studentPoints.ContainsKey(name))
                {
                    studentPoints.Add(name, 0);
                }

                studentPoints[name] += int.Parse(points);
            }

            var orderedResults = studentPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var student in orderedResults)
            {
                Console.WriteLine($"{student.Key}: {student.Value} [{string.Join(", ", studentCourse[student.Key])}]");
            }
        }
    }
}
