
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] command = Console.ReadLine().Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        while (command[0] != "End")
        {
            int id = int.Parse(command[1]);

            switch (command[0])
            {
                case "Create":
                    if (!accounts.ContainsKey(id))
                    {
                        BankAccount current = new BankAccount();
                        current.ID = id;
                        current.Balance = 0;
                        accounts.Add(id, current);
                    }
                    else
                    {
                        Console.WriteLine("Account already exists");
                    }
                    break;

                case "Deposit":
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        accounts[id].Deposit(double.Parse(command[2]));
                    }
                    break;

                case "Withdraw":
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        if (double.Parse(command[2]) > accounts[id].Balance)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else
                        {
                            accounts[id].Withdraw(double.Parse(command[2]));
                        }
                    }
                    break;

                case "Print":
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        Console.WriteLine(accounts[id].ToString());
                    }
                    break;
            }

            command = Console.ReadLine().Split(new[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

