using System;
using System.Collections.Generic;

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

                if (arr[2].Contains("@gmail.com"))
                {
                    Student student = new Student();
                    student.FirstName = arr[0];
                    student.LastName = arr[1];
                    student.Email = arr[2];
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
        public string Email { get; set; }
    }
}