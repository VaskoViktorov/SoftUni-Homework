using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication342
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string name = string.Empty;
            string[] names = new string[1];
            int sum = new int();
            int holder = new int();
            int GryCount = 0;
            int SlyCount = 0;
            int RavCount = 0;
            int HufCount = 0;
            for (int i = 0; i < num; i++)
            {
                name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] != ' ')
                    {
                        sum += (int)name[j];
                    }
                }
                holder = sum;
                sum %= 4;
                names = name.Split().ToArray();

                if (sum == 0)
                {
                    Console.WriteLine($"Gryffindor {holder}{names[0][0]}{names[1][0]}");
                    GryCount++;
                }
                else if (sum == 1)
                {
                    Console.WriteLine($"Slytherin {holder}{names[0][0]}{names[1][0]}");
                    SlyCount++;
                }
                else if (sum == 2)
                {
                    Console.WriteLine($"Ravenclaw {holder}{names[0][0]}{names[1][0]}");
                    RavCount++;
                }
                else if (sum == 3)
                {
                    Console.WriteLine($"Hufflepuff {holder}{names[0][0]}{names[1][0]}");
                    HufCount++;
                }
                sum = 0;
            }
            Console.WriteLine($"\nGryffindor: {GryCount}\nSlytherin: {SlyCount}\nRavenclaw: {RavCount}\nHufflepuff: {HufCount}");
        }
    }
}
