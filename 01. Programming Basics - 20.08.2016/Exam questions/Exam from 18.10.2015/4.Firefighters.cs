using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication105
{
    class Program
    {
        static void Main(string[] args)
        {
            var ff = int.Parse(Console.ReadLine());
            var word = "Nul";
            var kids = 0;
            var adults = 0;
            var siniors = 0;
            var savedkids = 0;
            var savedadults = 0;
            var savedsiniors = 0;
            var j = ff;
            while (word !="rain")
            {
                word = Console.ReadLine();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'K')
                        kids += 1;
                    else if (word[i] == 'A')
                        adults += 1;
                    else if (word[i] == 'S')
                        siniors += 1;                   
                }
                if (j > kids & j!=0)
                {
                    j -= kids;
                    savedkids += kids;
                }
                else if (j <= kids& kids>0)
                {
                    savedkids += j;
                    j = 0;
                }
                if (j > adults & j != 0)
                {
                    j -= adults;
                    savedadults += adults;
                }
                else if (j <= adults & adults > 0)
                {
                    savedadults += j;
                    j = 0;
                }
                if (j > siniors & j != 0)
                {
                    j -= siniors;
                    savedsiniors += siniors;
                }
                else if (j <= siniors & siniors > 0)
                {
                    savedsiniors += j;
                    j = 0;
                }
                j = ff;
                kids = 0;
                adults = 0;
                siniors = 0;
            }
            Console.WriteLine("Kids: {0}",savedkids);
            Console.WriteLine("Adults: {0}", savedadults);
            Console.WriteLine("Seniors: {0}", savedsiniors);

        }
    }
}
