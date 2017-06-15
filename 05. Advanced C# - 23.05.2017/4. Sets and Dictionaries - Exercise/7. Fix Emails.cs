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
            string name = Console.ReadLine();
            string email = "";
            Dictionary<string, string> goods = new Dictionary<string, string>();
            if (name != "stop")
            {
                email = Console.ReadLine();

                while (true)
                {
                    if (goods.ContainsKey(name))
                    {
                        goods[name] = email;
                    }
                    else
                    {
                        goods.Add(name, email);
                    }

                    name = Console.ReadLine();

                    if (name.Equals("stop"))
                    {
                        break;
                    }

                    email = Console.ReadLine();
                }
            }

            foreach (var item in goods)
            {

                if (item.Value[item.Value.Length - 2] != 'u')
                {
                    Console.WriteLine(item.Key + " -> " + item.Value);
                }
            }
        }
    }
}