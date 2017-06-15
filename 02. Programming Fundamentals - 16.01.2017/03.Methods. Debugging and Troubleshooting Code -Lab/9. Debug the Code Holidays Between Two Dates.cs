using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

       
        Console.WriteLine(HolidaysCounter(startDate,endDate));
    }
    static int HolidaysCounter(DateTime start, DateTime end)
    {
        var holidaysCount = 0;

        for (DateTime date = start; date <= end; date = date.AddDays(1))
        {

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
            
        }
        return (holidaysCount);
    }

}
