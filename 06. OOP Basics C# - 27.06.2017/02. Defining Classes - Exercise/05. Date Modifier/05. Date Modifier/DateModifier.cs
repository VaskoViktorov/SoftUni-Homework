using System;
using System.Globalization;

public class DateModifier
{
    
    public static double DayDiff(string firstString, string secondString)
    {
        DateTime firstDate = DateTime.ParseExact(firstString, "yyyy MM dd", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondString, "yyyy MM dd", CultureInfo.InvariantCulture);
        TimeSpan num = TimeSpan.FromTicks(secondDate.Ticks -firstDate.Ticks);
        
        return Math.Abs(num.TotalDays);
    }
}

