using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> list = new List<Student>();
            Regex reg = new Regex(@"^(02)|^(\+3592)");
            while (input != "END")
            {
                string[] arr = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (reg.IsMatch(arr[2]))
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
