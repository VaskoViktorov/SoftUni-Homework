
using System;

public class Program
{
    public static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        Console.WriteLine(DateModifier.DayDiff(first,second));
    }
}

