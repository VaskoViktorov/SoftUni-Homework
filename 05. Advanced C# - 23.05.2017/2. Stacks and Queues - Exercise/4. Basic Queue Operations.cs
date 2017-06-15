using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] func = Console.ReadLine().Split(new Char[] { ' ', '\n', '\t' }).Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(new Char[] { ' ', '\n', '\t' }).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < func[0]; i++)
            {
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < func[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(func[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
