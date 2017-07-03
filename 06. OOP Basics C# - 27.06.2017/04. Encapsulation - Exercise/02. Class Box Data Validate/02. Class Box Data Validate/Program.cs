
using System;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());
        
      
        try
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = new Box(length, width, height);
            Console.WriteLine($"{box.SurfaceArea()}\n{box.LateralSurfaceArea()}\n{box.Volume()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            
        }
        

    }

}
