using System.Collections.Generic;

namespace _01.ListyIterator
{
    using System;
    using System.Linq;

    public class ListyIteratorStartUp
    {
        public static void Main()
        {
            List<string> createCommand = Console.ReadLine().Split().ToList();

            ListyIterator<string> listyIterator;

            if (createCommand.Count > 1)
            {
                var items = createCommand.Skip(1).ToList();
                listyIterator = new ListyIterator<string>(items);
            }
            else
            {
                listyIterator = new ListyIterator<string>();
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(listyIterator.Print());
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }

                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "PrintAll":
                        try
                        {
                            foreach (var item in listyIterator)
                            {
                                Console.Write($"{item} ");
                            }
                            Console.WriteLine();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                            throw;
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}