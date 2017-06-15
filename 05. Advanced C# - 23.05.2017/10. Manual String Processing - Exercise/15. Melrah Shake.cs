using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {            
            StringBuilder text = new StringBuilder(Console.ReadLine());
            StringBuilder pattern = new StringBuilder(Console.ReadLine());
       
            while (pattern.Length>0)
            {
                var left = -1;
                var right = -1;

                for (int i = 0; i < text.Length-pattern.Length; i++)
                {
                    
                    if (text.ToString(i, pattern.Length) == pattern.ToString())
                    {
                        left = i;
                        break;
                    }
                }

                for (int i = text.Length; i >= pattern.Length; i--)
                {
                    if (text.ToString(i- pattern.Length, pattern.Length) == pattern.ToString())
                    {
                        right = i;
                        break;
                    }
                }

                if (left == right || left == -1 || right == -1)
                {
                    break;

                }
                
               text = text.Remove(left, pattern.Length).Remove(right - pattern.Length*2, pattern.Length);
               pattern = pattern.Remove(pattern.Length / 2, 1);
               Console.WriteLine("Shaked it.");                                           
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
