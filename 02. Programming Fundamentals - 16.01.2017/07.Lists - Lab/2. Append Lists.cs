using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication249
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array =  Console.ReadLine().Split('|').Reverse().ToArray();
            List <string> list = new List<string>();
           
            for (int i = 0; i < array.Length; i++)
            {
                
                    list.AddRange(array[i].Split(' ').ToList()); 
                    
                
            }

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == "")
                {
                    list.Remove(list[i]);
                }
                else if (list[i - 1] == "")
                {
                    list.Remove(list[i-1]);
                }
            }
            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
