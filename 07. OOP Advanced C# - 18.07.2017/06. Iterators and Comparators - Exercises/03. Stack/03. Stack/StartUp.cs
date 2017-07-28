using System;

namespace _03.Stack
{
    public class StartUp
    {
        public static void Main()
        {
            Stack<int> myStack = new Stack<int>();

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Push":
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            myStack.Push(int.Parse(tokens[i]));
                        }
                        break;
                    case "Pop":
                        try
                        {
                            myStack.Pop();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in myStack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
