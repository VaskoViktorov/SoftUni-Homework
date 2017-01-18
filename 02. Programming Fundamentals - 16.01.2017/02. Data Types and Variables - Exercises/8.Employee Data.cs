using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication146
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            int UEN = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {sex}\nPersonal ID: {ID}\nUnique Employee number: {UEN}");

        }
    }
}
