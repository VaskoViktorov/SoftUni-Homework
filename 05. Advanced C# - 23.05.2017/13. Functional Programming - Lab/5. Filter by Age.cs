using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication408
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
                  
            Func<int, Dictionary<string, int>> result = x =>
            {
                Dictionary<string, int> names = new Dictionary<string, int>();
                for (int i = 0; i < x; i++)
                {
                    string[] inp = Console.ReadLine().Split(new char[] { '\n', '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    names.Add(inp[0], int.Parse(inp[1]));
                }
                return names;
            };

            Dictionary<string, int> output = result(num);

            Action<Dictionary<string,int>> desiared = x =>
            {
                var type = Console.ReadLine();
                var age = int.Parse(Console.ReadLine());
                var outType = Console.ReadLine().Split().ToArray();

               
                Dictionary<string, int> people = new Dictionary<string, int>();
                if (type == "older")
                {
                    people = x.Where(h => h.Value >= age).ToDictionary(h => h.Key, k => k.Value);
                }
                else
                {
                    people = x.Where(h => h.Value <= age).ToDictionary(h => h.Key, k => k.Value);
                }

                if (outType.Length > 1)
                {
                    foreach (var one in people)
                    {
                        Console.WriteLine($"{one.Key} - {one.Value}");
                    }
                }
                else
                {
                    if (outType[0] == "name")
                    {
                        foreach (var one in people)
                        {
                            Console.WriteLine(one.Key);
                        }
                    }
                    else
                    {
                        foreach (var one in people)
                        {
                            Console.WriteLine(one.Value);
                        }
                    }
                }
            };

            desiared(output);

        }
    }
}
