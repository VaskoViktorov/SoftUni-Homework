using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication319
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] ladybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[size];
            long position = 0;
            foreach (var item in ladybugs)
            {

                if (item < field.Length && item >=0)
                {
                    field[item] = 1;
                }
            }
           
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {

                long startFly = long.Parse(command[0]);
                long endFly = long.Parse(command[2]);
                string direction = command[1];

                if (startFly < 0 || startFly >= field.Length)
                {
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }
                if (field[startFly] == 0)
                {
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }
                field[startFly] = 0;

                if (direction == "right")
                {

                    position = startFly + endFly;
                    if (position < 0 || position >= field.Length)
                    {
                        command = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                    else
                    {
                        while (position >= 0 && position < field.Length)
                        {

                            if (field[position] == 0)
                            {
                                field[position] = 1;
                                break;
                            }
                            else
                            {
                                position += endFly;
                            }
                        }                       
                    }
                }

                else if (direction == "left")
                {
                    position = startFly - endFly;
                    if (position < 0 || position >= field.Length)
                    {
                        command = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                    else
                    {
                        while (position >= 0 && position < field.Length)
                        {
                            
                            if (field[position] == 0)
                            {
                                field[position] = 1;
                                break;
                            }
                            else
                            {
                                position -= endFly;
                            }
                        }                       
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", field));
        }

    }
}




