using System;

class PriceChangeAlert
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double normalPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < num - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());            
            string message = PrintChangeInPrice(newPrice, normalPrice, GetChangeInPriceNumeric(normalPrice, newPrice),
                ChangeInPriceBool(GetChangeInPriceNumeric(normalPrice, newPrice), threshold));
            Console.WriteLine(message);
            normalPrice = newPrice;
        }
    }

    private static string PrintChangeInPrice(double newPrice, double normalPrice, double ChangeInPriceNumeric, bool ChangeInPriceBool)
    {
        string EndLine = "";

        if (ChangeInPriceNumeric == 0)
        {
            EndLine = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!ChangeInPriceBool)
        {
            EndLine = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", normalPrice, newPrice, ChangeInPriceNumeric * 100);
        }
        else if (ChangeInPriceBool && (ChangeInPriceNumeric > 0))
        {
            EndLine = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", normalPrice, newPrice, ChangeInPriceNumeric * 100);
        }
        else if (ChangeInPriceBool && (ChangeInPriceNumeric < 0))
            EndLine = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", normalPrice, newPrice, ChangeInPriceNumeric * 100);

        return EndLine;
    }

    private static bool ChangeInPriceBool(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double GetChangeInPriceNumeric(double NormalPrice, double NewPrice)
    {
        double changeInPrice = (NewPrice - NormalPrice) / NormalPrice;
        return changeInPrice;
    }
}
