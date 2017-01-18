using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberone = double.Parse(Console.ReadLine());
            var numbertwo = double.Parse(Console.ReadLine());
            var module = Console.ReadLine();
            var resultplus = numberone + numbertwo;
            var resultminus = numberone - numbertwo;
            var resultmultiply = numberone * numbertwo;
            var resultdivide = numberone / numbertwo;
            var resultparticle = numberone % numbertwo;

            if (module == "+")
            {
                if (resultplus % 2.0 == 0)
                    Console.WriteLine("{0} + {1} = {2} - even", numberone, numbertwo, resultplus);
                else
                    Console.WriteLine("{0} + {1} = {2} - odd", numberone, numbertwo, resultplus);
            }
            else if (module == "-")
            {
                if (resultminus % 2.0 == 0)
                    Console.WriteLine("{0} - {1} = {2} - even", numberone, numbertwo, resultminus);
                else
                    Console.WriteLine("{0} - {1} = {2} - odd", numberone, numbertwo, resultminus);
            }
            else if (module == "*")
            {
                if (resultmultiply % 2.0 == 0)
                    Console.WriteLine("{0} * {1} = {2} - even", numberone, numbertwo, resultmultiply);
                else
                    Console.WriteLine("{0} * {1} = {2} - odd", numberone, numbertwo, resultmultiply);
            }
            else if (module == "/" && numberone == 0 || module == "/" && numbertwo == 0 || module == "/")
            {

                if (numberone == 0)
                    Console.WriteLine("Cannot divide {0} by zero", numbertwo);
                else if (numbertwo == 0)
                    Console.WriteLine("Cannot divide {0} by zero", numberone);
                else
                    Console.WriteLine("{0} / {1} = {2}", numberone, numbertwo, resultdivide);
            }
            else if (module == "%" && numberone == 0 || module == "%" && numbertwo == 0 || module == "%")
            {

                if (numberone == 0)
                    Console.WriteLine("Cannot divide {0} by zero", numbertwo);
                else if (numbertwo == 0)
                    Console.WriteLine("Cannot divide {0} by zero", numberone);
                
                else

                    Console.WriteLine("{0} % {1} = {2}", numberone, numbertwo, resultparticle);
            }
        }
    }
}
    