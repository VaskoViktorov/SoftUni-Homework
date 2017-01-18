using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication135
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var patients = 0;
            var treated = 0;
            var untreated = 0;
            var doctors = 7;
            for (int i = 1; i <= n; i++)
            {
                patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        doctors += 1;
                    }
                }
                if (patients >= doctors)
                {
                    untreated += patients - doctors;
                    treated += doctors;
                    
                }
                else
                {
                    treated += patients;
                }

               
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);

        }
    }
}
