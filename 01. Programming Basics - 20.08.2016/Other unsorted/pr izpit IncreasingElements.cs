using System;

class IncreasingElements
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var previousNumber = -1000;
        var count = 0;
        var maxCount = 0;

        for (int i = 1; i <= n; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber > previousNumber)
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count > maxCount)
            {
                maxCount = count;
            }

            previousNumber = currentNumber;
        }

        Console.WriteLine(maxCount);
    }
}
