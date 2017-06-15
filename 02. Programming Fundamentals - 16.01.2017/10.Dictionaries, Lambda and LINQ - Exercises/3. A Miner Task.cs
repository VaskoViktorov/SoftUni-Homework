using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication266
{
    class Program
    {
        static void Main(string[] args)
        {
            string metal = Console.ReadLine();
            int amaunt = 0;
            Dictionary<string, int> goods = new Dictionary<string, int>();
            if (metal != "stop")
            {
                amaunt = int.Parse(Console.ReadLine());

                while (true)
                {
                    if (goods.ContainsKey(metal))
                    {
                        goods[metal] += amaunt;
                    }
                    else
                    {
                        goods.Add(metal, amaunt);
                    }

                    metal = Console.ReadLine();

                    if (metal.Equals("stop"))
                    {
                        break;
                    }

                    amaunt = int.Parse(Console.ReadLine());
                }
            }

            foreach (var item in goods)
            {

                
                    Console.WriteLine(item.Key + " -> " + item.Value);
                
            }
        }
    }
}
