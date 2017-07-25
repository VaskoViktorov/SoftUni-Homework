using System;

namespace _01_Generic_Box
{
   public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            IBox<int> box = new Box<int>();

            for (int i = 0; i < num; i++)
            {
                box.Generate(int.Parse(Console.ReadLine()));
                Console.WriteLine(box.ToString());                
            }
            
           
        }
    }
}
