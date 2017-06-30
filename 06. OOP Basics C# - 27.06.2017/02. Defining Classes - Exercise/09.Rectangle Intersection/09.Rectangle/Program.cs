
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numAndCecks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < numAndCecks[0]; i++)
        {
            string[] input = Console.ReadLine().Split();
            Rectangle rec = new Rectangle();
            rec.ID = input[0];
            rec.Width = double.Parse(input[1]);
            rec.Height = double.Parse(input[2]);
            rec.HorizontalCord = double.Parse(input[3]);
            rec.VerticalCord = double.Parse(input[4]);
            rectangles.Add(input[0], rec);
        }

        for (int i = 0; i < numAndCecks[1]; i++)
        {
            string[] input = Console.ReadLine().Split();
            var first = rectangles.Where(x => x.Key == input[0]).Select(x => x.Value);
            var second = rectangles.Where(x => x.Key == input[1]).Select(x => x.Value);
            foreach (var fi in first)
            {
                foreach (var se in second)
                {
                    if (fi.VerticalCord >= se.VerticalCord && fi.VerticalCord - fi.Height <= se.VerticalCord && fi.HorizontalCord <= se.HorizontalCord && fi.HorizontalCord + fi.Width >= se.HorizontalCord ||
                        fi.VerticalCord >= se.VerticalCord && fi.VerticalCord - fi.Height <= se.VerticalCord && fi.HorizontalCord >= se.HorizontalCord && fi.HorizontalCord <= se.HorizontalCord + se.Width ||
                        fi.VerticalCord <= se.VerticalCord && fi.VerticalCord >= se.VerticalCord - se.Height && fi.HorizontalCord <= se.HorizontalCord && fi.HorizontalCord + fi.Width >= se.HorizontalCord ||
                        fi.VerticalCord <= se.VerticalCord && fi.VerticalCord >= se.VerticalCord - se.Height && fi.HorizontalCord >= se.HorizontalCord && fi.HorizontalCord <= se.HorizontalCord + se.Width)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
        }
    }
}

