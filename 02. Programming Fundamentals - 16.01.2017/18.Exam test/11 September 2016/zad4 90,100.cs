using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication333
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];

            var size = "";
            var program = "";
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }

            string[] findMe = Console.ReadLine().Split().ToArray();
            List<string> splited = new List<string>();
            string[] file = new string[1];
            Dictionary<string, string> end = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                splited = input[i].Split(new string[] { "\\", ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                file = splited[splited.Count - 2].Split('.').ToArray();
                if (splited[0] == findMe[2] && file[file.Length - 1] == findMe[0])
                {
                    program = splited[splited.Count - 2];
                    size = splited[splited.Count - 1];
                    if (!end.ContainsKey(program))
                    {
                        end.Add(program, size);
                    }
                    else
                    {
                        end[program] = size;
                    }

                }
            }

            if (end.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {

                foreach (var item in end.OrderByDescending(x => x.Value).ThenBy(h => h.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB");
                }
            }


        }
    }
}
