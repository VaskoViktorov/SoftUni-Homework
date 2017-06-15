using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication260
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] power = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                     
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == power[0])
                {                
                    for (int j = 0; j <= power[1]; j++)
                    {
                        if (i - j >= 0)
                        {
                            nums[i -j] = 0;
                        }
                        if (i + j <= nums.Count)
                        {
                            nums[i + j] = 0;
                        }
                    }
                }
            } 
                                                  
           Console.WriteLine(nums.Sum());          
        }
    }
}
