using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            char[][] matrix = new char[dimensions[0]][];
            int turns = 0;
            long money = 50;
            int hotels = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[dimensions[1]];
                var boxTypes = Console.ReadLine();

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = boxTypes[col];
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (i % 2 == 0)
                {

                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        var box = matrix[i][j];

                        switch (box)
                        {
                            case 'H':

                                hotels++;
                                Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                                money = 0;
                                break;
                            case 'S':
                                var HasToBuy = (i + 1) * (j + 1);
                                money -= HasToBuy;
                                if (money < 0)
                                {
                                    Console.WriteLine($"Spent {money+HasToBuy} money at the shop.");
                                    money = 0;
                                    
                                }
                                else
                                {
                                    Console.WriteLine($"Spent {HasToBuy} money at the shop.");
                                }
                                break;
                            case 'J':
                                Console.WriteLine($"Gone to jail at turn {turns}.");
                                turns += 2;
                                money += hotels * 20;
                                break;
                        }
                        money += hotels * 10;
                        turns++;
                    }
                }
                else
                {
                    for (int j = matrix[i].Length-1; j >= 0; j--)
                    {
                        var box = matrix[i][j];

                        switch (box)
                        {
                            case 'H':
                                
                                hotels++;
                                Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                                money = 0;
                                break;
                            case 'S':
                                var HasToBuy = (i + 1) * (j + 1);                                                              
                                money -= HasToBuy;
                                if (money <= 0)
                                {
                                    money = 0;
                                    Console.WriteLine($"Spent {money} money at the shop.");
                                }
                                else
                                {
                                    Console.WriteLine($"Spent {HasToBuy} money at the shop.");
                                }
                                break;
                            case 'J':
                                Console.WriteLine($"Gone to jail at turn {turns}.");
                                turns += 2;
                                money += hotels * 20;
                                break;
                        }
                        money += hotels * 10;
                        turns++;
                    }
                }
                
            }
            Console.WriteLine($"Turns {turns}\nMoney {money}");
        }
    }
}
