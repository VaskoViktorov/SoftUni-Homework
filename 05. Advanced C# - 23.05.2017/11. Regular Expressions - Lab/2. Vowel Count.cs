﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication389
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =Console.ReadLine();
            Regex reg = new Regex(@"[AOEUIYaoeuiy]");
            MatchCollection match = reg.Matches(text);

            Console.WriteLine($"Vowels: {match.Count}");
        }
    }
}
