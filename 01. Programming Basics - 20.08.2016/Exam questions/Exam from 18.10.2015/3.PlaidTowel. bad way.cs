using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication102
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var background = char.Parse(Console.ReadLine());
            var front = char.Parse(Console.ReadLine());
            var j = n;
            var leftRight = j ;
            var backSignMid = 1;
            var mid = n*2-3;
           
            if (n % 2 == 0)
            {
               
                j =n+1;
            }
          
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, leftRight), front, new string(background, mid + 2));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, leftRight-1),
                                                                front,
                                                                new string(background, backSignMid),
                                                                new string(background, mid));
                leftRight--;
                backSignMid += 2;
                mid -= 2;

            }

            mid = n * 2 - 1;
           
            Console.WriteLine("{0}{1}{0}{1}{0}", front, new string(background, mid));
            j -= 1;
            if (n % 2 == 0)
            {
                leftRight = 1;
                backSignMid -= 2;
                mid = 1;
                j += 1;
            }
            else
            {
                leftRight = 1 ;
                backSignMid -= 2;
                mid = 1;
                
                j += 1;
            }
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, leftRight),
                                                                front,
                                                                new string(background, backSignMid),
                                                                new string(background, mid));
                leftRight++;
                backSignMid -= 2;
                mid += 2;
            }

        
            
                mid = n * 2-1;
            
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, leftRight), front, new string(background, mid));

             j = n;
             leftRight = j;
             backSignMid = 1;
            mid = n * 2 - 3;

            if (n % 2 == 0)
            {

                j = n + 1;
            }

            

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, leftRight - 1),
                                                                front,
                                                                new string(background, backSignMid),
                                                                new string(background, mid));
                leftRight--;
                backSignMid += 2;
                mid -= 2;

            }

            mid = n * 2 - 1;

            Console.WriteLine("{0}{1}{0}{1}{0}", front, new string(background, mid));
            j -= 1;
            if (n % 2 == 0)
            {
                leftRight = 1;
                backSignMid -= 2;
                mid = 1;
                j += 1;
            }
            else
            {
                leftRight = 1;
                backSignMid -= 2;
                mid = 1;

                j += 1;
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, leftRight),
                                                                front,
                                                                new string(background, backSignMid),
                                                                new string(background, mid));
                leftRight++;
                backSignMid -= 2;
                mid += 2;
            }



            mid = n * 2 - 1;

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, leftRight), front, new string(background, mid));



        }
    }
}

