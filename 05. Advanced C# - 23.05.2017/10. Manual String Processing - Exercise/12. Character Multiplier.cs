using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication302
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();
            string firstWord = text[0];
            string secondWord = text[1];
            int max = Math.Max(firstWord.Length, secondWord.Length);
            BigInteger result = 0;

            for (int i = 0; i < max; i++)
            {
                if (firstWord.Length > i && secondWord.Length > i)
                {                    
                    result += (int)firstWord[i] * (int)secondWord[i];
                }
                else if (firstWord.Length <= i)
                {                   
                    result += (int)secondWord[i];
                }
                else if (secondWord.Length <= i)
                {
                    result += (int)firstWord[i];
                }

            }
            Console.WriteLine(result);
        }
    }
}
