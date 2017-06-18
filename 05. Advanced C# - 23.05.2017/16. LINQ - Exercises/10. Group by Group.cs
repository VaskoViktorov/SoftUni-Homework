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
            List<Person> list = new List<Person>();
            while (input != "END")
            {
                string[] arr = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                Person student = new Person();
                student.Group = int.Parse(arr[2]);
                student.Name = arr[0] + " " + arr[1];
                list.Add(student);

                input = Console.ReadLine();
            }

            list.GroupBy(
            p => p.Group, p.Name,
            (key, value) => new { Group = key, Name = value.ToList() })
            .OrderBy(x => x.Group)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Group} - {string.Join(", ",x.Name)}"));

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }
        
        
    }
}
