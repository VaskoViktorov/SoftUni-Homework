﻿using System;
using System.Linq;

namespace _10.Create_Custom_Class_Attribute
{
    public class StartUp
    {
        public static void Main()
        {
            var cmd = Console.ReadLine();

            var attribute = typeof(Weapon).GetCustomAttributes(typeof(CustumAttribute), true)
                .FirstOrDefault() as CustumAttribute;

            while (cmd != "END")
            {
                switch (cmd)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attribute.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {attribute.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attribute.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
