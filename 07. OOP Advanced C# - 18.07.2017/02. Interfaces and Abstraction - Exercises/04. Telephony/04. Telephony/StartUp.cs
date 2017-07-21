
using System;

public class StartUp
{
    public static void Main()
    {

        string[] phonenumbers = Console.ReadLine().Split(' ');
        ICallable phone = new Smartphone();

        foreach (var phonenumber in phonenumbers)
        {
            try
            {
                Console.WriteLine(phone.Call(phonenumber));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        string[] sites = Console.ReadLine().Split(' ' );
        IBrowsable smartphone = new Smartphone();

        foreach (var site in sites)
        {
            try
            {
                Console.WriteLine(smartphone.Brawsing(site));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

    }
    
}