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
            char[] delimiters = new char[] { ' ', ',' };
            List<string> input = Console.ReadLine().Split(delimiters,StringSplitOptions.RemoveEmptyEntries).ToList();
            person = input[0];
            if (person == "JOKER") break;
 
            List<string> cards = new List<string>();
            for (int i = 1; i < input.Count; i++) cards.Add( input[i]);
            if (!hands.ContainsKey(person))
            {
                hands[person] = cards;
            }
            else
            {
                hands[person].AddRange(cards);
            }
 
        }// end of while
 
        printResult(hands);
       
    }
 
    private static void printResult(Dictionary<string, List<string>> hands)
    {
        foreach (var hand in hands)
        {
            string person = hand.Key;
            List<string> personHands = hand.Value.Distinct().ToList();            
            int power = 0;
            int type = 0;
            int value = 0;
            for (int i = 0; i < personHands.Count; i++)
            {
                string card = personHands[i];
                string cardPower = card.Substring(0, card.Length - 1);
                char cardType = card[card.Length-1];
                power = findThePower(cardPower);
                type = findTheType(cardType);
                value += power * type;
            }
            Console.WriteLine(person+ " "+value);
        }
    }
 
 
 
    private static int findTheType(char v)
    {
            int type = 0;
            switch (v)
            {
                case 'S':
                    type = 4;
                    break;
                case 'H':
                    type = 3;
                    break;
                case 'D':
                    type = 2;
                    break;
                case 'C':
                    type = 1;
                    break;
                default:
                    break;
            }
            return type;
        }
 
    private static int findThePower(string v)
    {
        int cardPower = 0;
        switch (v)
        {
            case "1":
                cardPower = 1;
                break;
            case "2":
                cardPower = 2;
                break;
            case "3":
                cardPower = 3;
                break;
            case "4":
                cardPower = 4;
                break;
            case "5":
                cardPower = 5;
                break;
            case "6":
                cardPower = 6;
                break;
            case "7":
                cardPower = 7;
                break;
            case "8":
                cardPower = 8;
                break;
            case "9":
                cardPower = 9;
                break;
            case "10":
                cardPower = 10;
                break;
            case "J":
                cardPower = 11;
                break;
            case "Q":
                cardPower = 12;
                break;
            case "K":
                cardPower = 13;
                break;
            case "A":
                cardPower = 14;
                break;
            default:
                break;
        }
        return cardPower;
    }
}