using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication331
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameters = int.Parse(Console.ReadLine());
            char[,] array2D = new char[parameters, parameters];
            var starti = 0;
            var startj = 0;
            for (int i = 0; i < parameters; i++)
            {
                string input = Console.ReadLine();
                while (input.Length != parameters)
                {
                    input = input + "X";
                }
                for (int j = 0; j < parameters; j++)
                {
                    array2D[i, j] = input[j];

                    if (input[j] == 'S')
                    {
                        starti = i;
                        startj = j;
                    }
                }
            }
            string movement = Console.ReadLine();
            int counter = 0;
            bool succsess = false;
            for (int i = 0; i < movement.Length; i++)
            {
                counter++;
                if (movement[i] == 'D')
                {
                    array2D[starti, startj] = '0';

                    if (starti > parameters - 1)
                    {
                        starti = 0;
                    }
                    else
                    {
                        starti++;
                    }
                    while (array2D[starti, startj] == 'X')
                    {
                        starti++;
                    }

                }
                if (movement[i] == 'U')
                {
                    array2D[starti, startj] = '0';

                    if (starti < 0)
                    {
                        starti = parameters - 1;
                    }
                    else
                    {
                        starti--;
                    }
                    while (array2D[starti, startj] == 'X')
                    {
                        starti--;
                    }

                }
                if (movement[i] == 'L')
                {
                    array2D[starti, startj] = '0';

                    if (startj < 0)
                    {
                        startj = parameters - 1;
                    }
                    else
                    {
                        startj--;
                    }
                    while (array2D[starti, startj] == 'X')
                    {
                        startj--;
                    }

                }
                if (movement[i] == 'R')
                {
                    array2D[starti, startj] = '0';

                    if (startj > parameters - 1)
                    {
                        startj = 0;
                    }
                    else
                    {
                        startj++;
                    }
                    while (array2D[starti, startj] == 'X')
                    {
                        startj++;
                    }
                }

                if (array2D[starti, startj] == 'E')
                {
                    succsess = true;
                    Console.WriteLine($"Experiment successful. {counter} turns required.");
                    break;
                }
                else
                {
                    array2D[starti, startj] = 'S';
                }
            }

            if (succsess == false)
            {
                Console.WriteLine($"Robot stuck at {starti} {startj}. Experiment failed.");
            }
        }
    }
}
