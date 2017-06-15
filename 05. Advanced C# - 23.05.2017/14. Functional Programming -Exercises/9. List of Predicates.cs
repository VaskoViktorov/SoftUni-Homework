using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            long lenght = long.Parse(Console.ReadLine());

            List<long> input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            
            Func<long,List<long>, List<long>> func = (maxNum,list) =>
            {
                List<long> nums = new List<long>();
                int counter = 0;
                for (int i = 1; i <= maxNum; i++)
                {
                    foreach (var item in list)
                    {

                        if (Math.Abs(i) % item == 0)
                        {
                            counter ++;
                        }

                    }
                    if (counter == list.Count)
                    {
                        nums.Add(i);
                    }
                    counter = 0;
                }

                return nums;
            };

            Console.WriteLine(string.Join(" ", func(lenght,input)));
        }
    }
}
