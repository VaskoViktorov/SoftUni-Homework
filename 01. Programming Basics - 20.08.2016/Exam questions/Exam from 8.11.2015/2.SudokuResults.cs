using System;

class Problem02SudokuResult
{
    static void Main()
    {
        var games = 0.0;
        string time = Console.ReadLine();
        var totaltime = 0.0;
        while (time != "Quit")
        {
            games++;
            var min = int.Parse(time.Substring(0, 2));
            var sec = int.Parse(time.Substring(3, 2));
            totaltime += (min * 60 + sec);

            time = Console.ReadLine();
        }
        double avrtime = totaltime / games;
        if (avrtime <= 720)
        {
            Console.WriteLine("Gold Star");
        }
        else if (avrtime > 720 && avrtime <= 1440)
        {
            Console.WriteLine("Silver Star");
        }
        else if (avrtime > 1440)
        {
            Console.WriteLine("Bronze Star");
        }
        Console.WriteLine("Games - {0} \\ Average seconds - {1}",games, Math.Ceiling(avrtime));
    }
}    