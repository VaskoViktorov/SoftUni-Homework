using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

            string[] command = Console.ReadLine().Split();
            int start = 0;
            int end = 0;
            List<string> currList = new List<string>();

            while (!command[0].Equals("end"))
            {
                switch (command[0])
                {
                    case "reverse":
                        start = int.Parse(command[2]);
                        end = int.Parse(command[4]);

                        if (start < 0 || end < 0 || start >= input.Count || (start + end) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        currList = input.Skip(start).Take(end).Reverse().ToList();
                        input.RemoveRange(start, end);
                        input.InsertRange(start, currList);
                        break;

                    case "sort":
                        start = int.Parse(command[2]);
                        end = int.Parse(command[4]);

                        if (start < 0 || end < 0 || start >= input.Count || (start + end) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        currList = input.Skip(start).Take(end).OrderBy(str => str).ToList();

                        input.RemoveRange(start, end);
                        input.InsertRange(start, currList);

                        break;

                    case "rollLeft":
                        end = int.Parse(command[1]);

                        if (end < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < (end % input.Count); i++)
                        {
                            string element = input[0];

                            input.RemoveAt(0);
                            input.Add(element);
                        }
                        break;

                    case "rollRight":
                        end = int.Parse(command[1]);

                        if (end < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < (end % input.Count); i++)
                        {
                            string element = input[input.Count - 1];

                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, element);
                        }
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }


            string output = string.Join(", ", input);
            Console.WriteLine($"[{output}]");

        }
    }
}
