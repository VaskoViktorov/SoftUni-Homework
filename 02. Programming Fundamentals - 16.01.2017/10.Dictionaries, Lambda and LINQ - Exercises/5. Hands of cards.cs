using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Hands_of_cards
{
    static void Main()
    {
        Dictionary<string, List<string>> hands = new Dictionary<string, List<string>>();

        string person = "";

        while (true)
        {           
            List<string> input = Console.ReadLine().Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            person = input[0];
            if (person == "JOKER") break;

            List<string> cards = input[1].Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            if (!hands.ContainsKey(person))
            {
                hands[person] = cards;
            }
            else
            {
                hands[person].AddRange(cards);
            }

        }

        printResult(hands);

    }

    private static void printResult(Dictionary<string, List<string>> hands)
    {
        
        Dictionary<string, int> goods = new Dictionary<string, int>{
            { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 },
            { "6", 6 }, { "7", 7 }, { "8", 8 }, { "9", 9 }, { "10", 10 },
            { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 },
            { "S", 4 }, { "H", 3 }, { "D", 2 }, { "C", 1 }};

        foreach (var hand in hands)
        {
            string person = hand.Key;
            List<string> personHands = hand.Value.Distinct().ToList();
            int value = 0;
            string cardV = "";
            string color = "";

            for (int i = 0; i < personHands.Count; i++)
            {                
                if (personHands[i] == "10S" || personHands[i] == "10H" || personHands[i] == "10D" || personHands[i] == "10C")
                {
                    cardV = "10";
                }
                else
                {
                    cardV = (personHands[i][personHands[i].Length - 2]).ToString();
                }

                color = (personHands[i][personHands[i].Length - 1]).ToString();

                value += goods[cardV] * goods[color];
            }
            Console.WriteLine(person + ": " + value);
        }
    }
}
