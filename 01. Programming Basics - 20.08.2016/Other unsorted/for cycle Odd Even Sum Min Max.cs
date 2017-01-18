using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double OddSum = 0.0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0.0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;
            if (num == 0)
                Console.WriteLine("OddSum ={0},\nOddMin=No,\nOddMax=No,\nEvenSum ={1},\nEvenMin=No,\nEvenMax=No", OddSum, EvenSum);
            else
            { 
                for (int i = 0; i < num; i++)
                {
                    var first = double.Parse(Console.ReadLine());

                    if (i % 2 == 1)
                    {
                        EvenSum += first;
                        {
                            if (EvenMin > first)
                            {
                                EvenMin = first;
                            }
                            if (EvenMax < first)
                            {
                                EvenMax = first;
                            }
                        }
                    }
                    else
                    {
                        OddSum += first;
                        {
                            if (OddMin > first)
                            {
                                OddMin = first;
                            }
                            if (OddMax < first)
                            {
                                OddMax = first;
                            }
                        }
                    }
                }

            if (num == 1)
                Console.WriteLine("OddSum ={0},\nOddMin={1},\nOddMax={2},\nEvenSum ={3},\nEvenMin=No,\nEvenMax=No"
                   , OddSum, OddMin, OddMax, EvenSum);
            else
                Console.WriteLine("OddSum ={0},\nOddMin={1},\nOddMax={2},\nEvenSum ={3},\nEvenMin={4},\nEvenMax={5}"
                    , OddSum, OddMin, OddMax, EvenSum, EvenMin, EvenMax);
        }
        }
    }
}
