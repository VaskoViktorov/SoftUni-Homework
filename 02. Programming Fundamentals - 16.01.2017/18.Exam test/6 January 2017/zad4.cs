using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication349
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new string[] { ",", " ", "\t" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string leftSide = string.Empty;
            string rightSide = string.Empty;
            string winningTicket = @"([$]{6,}|[@]{6,}|[#]{6,}|[\^]{6,})";
            string jackpot = @"([$]{20}|[@]{20}|[#]{20}|[\^]{20})";
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                Regex bigJacpot = new Regex(jackpot);
                Regex winTicket = new Regex(winningTicket);
                leftSide = ticket.Substring(0, 10);
                rightSide = ticket.Substring(10, 10);
                Match left = winTicket.Match(leftSide);
                Match right = winTicket.Match(rightSide);
                if (bigJacpot.IsMatch(ticket))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                }
                else if (!winTicket.IsMatch(leftSide) || !winTicket.IsMatch(rightSide))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(left.ToString().Length, right.ToString().Length)}{left.ToString()[0]}");
                }
            }
        }
    }
}
