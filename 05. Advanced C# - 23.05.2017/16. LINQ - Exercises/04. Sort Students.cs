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

                
                    Student student = new Student();
                    student.FirstName = arr[0];
                    student.LastName = arr[1];                   
                    list.Add(student);
                

                input = Console.ReadLine();
            }

            foreach (var name in list.OrderBy(x => x.LastName).ThenByDescending(y => y.FirstName))
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
