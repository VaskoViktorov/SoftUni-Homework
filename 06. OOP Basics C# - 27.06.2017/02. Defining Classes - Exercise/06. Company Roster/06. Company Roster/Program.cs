
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Dictionary<string, List<Employee>> list = new Dictionary<string, List<Employee>>();
        Dictionary<string, double> depSalary = new Dictionary<string, double>();
        for (int i = 0; i < num; i++)
        {
            var hasAge = false;
            string[] input = Console.ReadLine().Split();
            if (!list.ContainsKey(input[3]))
            {
                list.Add(input[3], new List<Employee>());
            }
            if (!depSalary.ContainsKey(input[3]))
            {
                depSalary.Add(input[3], 0);
            }
            depSalary[input[3]] += double.Parse(input[1]);            
            if (input.Length > 4)
            {
                var ah = 0;
                hasAge = int.TryParse(input[4], out ah);
            }
            
            if (input.Length == 6)
            {
                Employee current = new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5]));
                list[input[3]].Add(current);
            }
            else if (input.Length == 4)
            {
                Employee current = new Employee(input[0], double.Parse(input[1]), input[2], input[3]);
                list[input[3]].Add(current);
            }
            else if (hasAge)
            {
                Employee current = new Employee(input[0], double.Parse(input[1]), input[2], input[3], int.Parse(input[4]));
                list[input[3]].Add(current);
            }
            else
            {
                Employee current = new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4]);
                list[input[3]].Add(current);
            }
        }
        var max = depSalary.Max(x => x.Value);
        var dep = depSalary.Where(x => x.Value == max);
        foreach (var a in dep)
        {
            foreach (var b in list)
            {
                if (a.Key.Equals(b.Key))
                {
                    Console.WriteLine($"Highest Average Salary: {b.Key}");
                    foreach (var asd in b.Value.OrderByDescending(x => x.Salary))
                    {
                        Console.WriteLine($"{asd.Name} {asd.Salary:f2} {asd.Email} {asd.Age}");
                    }
                }
            }
           
        }
    }
}

