using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication247
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] word = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                word[i] = array.Substring(i,1);
            }
                      
            string[] aToZ = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
            "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < aToZ.Length; j++)
                {
                    if (word[i] == aToZ[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
            
        }
    }
}
