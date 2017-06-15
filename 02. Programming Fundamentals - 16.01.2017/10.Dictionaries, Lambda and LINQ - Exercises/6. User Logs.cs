using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication269
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new Dictionary<string, List<string>>();
            string person = "";
            while (true)
            {
                List<string> input = Console.ReadLine()
                                       .Split(new string[] { "user=" }, StringSplitOptions.RemoveEmptyEntries)
                                       .ToList();

                if (input[0] == "end")
                {
                    break;
                }
                person = input[1];

                List<string> IPandMSG = input[0].Split(new string[] { " ", "IP=" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!list.ContainsKey(person))
                {
                    list[person] = IPandMSG;
                }
                else
                {
                    list[person].AddRange(IPandMSG);
                }


            }

            var IpsAndMsg = new Dictionary<string, int>();

            foreach (var i in list.OrderBy(x => x.Key))
            {
                List<string> Ips = i.Value.ToList();

                for (int j = 0; j < Ips.Count; j++)
                {
                    if (j % 2 == 0)
                    {
                        if (IpsAndMsg.ContainsKey(Ips[j]))
                        {
                            IpsAndMsg[Ips[j]] += 1;

                        }
                        else
                        {
                            IpsAndMsg[Ips[j]] = 1;
                        }
                    }
                }

                Console.WriteLine($"{i.Key}: ");

                var h = 0;
                foreach (var item in IpsAndMsg)
                {
                    h++;
                    if (h == IpsAndMsg.Count)
                    {
                        Console.WriteLine($"{item.Key} => {item.Value}.");
                    }
                    else
                    {
                        Console.Write($"{item.Key} => {item.Value}, ");
                    }

                }
                IpsAndMsg.Clear();
            }



        }


    }
}

