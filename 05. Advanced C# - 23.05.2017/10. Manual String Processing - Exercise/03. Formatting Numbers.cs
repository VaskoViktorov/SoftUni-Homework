using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(new []{' ','\t','\n'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string binary = Convert.ToString(long.Parse(nums[0]), 2);
            if (binary.Length > 10)
            {
                binary = binary.Substring(0, 10);
            }

            Console.WriteLine("|{0,-10}|{1,10}|{2,10:f2}|{3,-10:f3}|", long.Parse(nums[0]).ToString("X"), binary.PadLeft(10, '0'), decimal.Parse(nums[1]), decimal.Parse(nums[2]));
        }
    }
}
