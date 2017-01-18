using System;

class SumStep3
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var sum1 = 0;
        var sum2 = 0;
        var sum3 = 0;

        for (int i = 0; i < n; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());

            if (i % 3 == 0)
            {
                sum1 += currentNumber;
            }
            else if (i % 3 == 1)
            {
                sum2 += currentNumber;
            }
            else if (i % 3 == 2)
            {
                sum3 += currentNumber;
            }
        }

        Console.WriteLine("sum1 = " + sum1);
        Console.WriteLine("sum2 = " + sum2);
        Console.WriteLine("sum3 = " + sum3);
    }
}
