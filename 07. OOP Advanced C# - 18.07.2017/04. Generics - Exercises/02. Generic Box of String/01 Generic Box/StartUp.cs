using System;

namespace _01_Generic_Box
{
   public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            IBox<string> box = new Box<string>();
            for (int i = 0; i < num; i++)
            {
                box.Generate(Console.ReadLine());
                Console.WriteLine(box.ToString());                
            }
            
           
        }
    }
}
