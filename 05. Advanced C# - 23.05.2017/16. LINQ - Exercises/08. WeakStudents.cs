using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> list = new List<Student>();
            while (input != "END")
            {
                string[] arr = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                var other = arr.Skip(2).Take(arr.Length - 2).Where(x => int.Parse(x) <= 3).ToArray();
                if (other.Length >= 2)
                {
                    Student student = new Student();
                    student.FirstName = arr[0];
                    student.LastName = arr[1];
                    list.Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var name in list)
            {
                Console.WriteLine($"{name.FirstName} {name.LastName}");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}