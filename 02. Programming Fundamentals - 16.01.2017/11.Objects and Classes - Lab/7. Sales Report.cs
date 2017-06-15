using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication276
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> list = ReadTotal(num);
          
            foreach (var item in list.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key:f2} -> {item.Value:f2}");
            }
            
        }

        static Dictionary<string, decimal> ReadTotal(int num)
        {
            string[] input = new string[num];
            for (int i = 0; i < num; i++)
            {
                input[i]= Console.ReadLine();
            }

            Dictionary<string, decimal> list= new Dictionary<string, decimal>();

            for (int i = 0; i < num; i++)
            {
                var splited = input[i].Split().ToArray();

                decimal priceQuantity = decimal.Parse(splited[2])*decimal.Parse(splited[3]);

                if (!list.ContainsKey(splited[0]))
                {
                    list.Add(splited[0], priceQuantity);
                }
                else
                {
                    list[splited[0]] += priceQuantity;
                }              
            }
            return list;

        }
    }
  
}
