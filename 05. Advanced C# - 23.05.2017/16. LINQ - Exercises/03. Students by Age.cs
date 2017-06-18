using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                if (int.Parse(arr[2]) <=24 && int.Parse(arr[2]) >= 18)
                {                  
                    Student student = new Student();
                    student.FirstName = arr[0];
                    student.LastName = arr[1];
                    student.Age = int.Parse(arr[2]);
                    list.Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var name in list)
            {
                Console.WriteLine($"{name.FirstName} {name.LastName} {name.Age}");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
