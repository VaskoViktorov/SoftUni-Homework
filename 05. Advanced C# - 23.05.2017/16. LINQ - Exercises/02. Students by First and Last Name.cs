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
                string[] arr = input.Split(new []{' ','\t','\n'}, StringSplitOptions.RemoveEmptyEntries);

                if (arr[0].CompareTo(arr[1]) < 0)
                {
                    var firstName = arr[0];
                    var lastName = arr[1];
                    Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
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
