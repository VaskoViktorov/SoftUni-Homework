
using System;
using System.Text.RegularExpressions;

public class Smartphone : ICallable, IBrowsable
{
  
    public string Call(string phonenumber)
    {
        Regex reg = new Regex(@"^([0-9]+)$");

        if (reg.IsMatch(phonenumber))
        {
            return $"Calling... {phonenumber}";
        }

        throw new ArgumentException("Invalid number!");
    }

    public string Brawsing(string site)
    {
        Regex reg = new Regex(@"([0-9])");

        if (!reg.IsMatch(site))
        {
            return $"Browsing: {site}!";
        }

        throw new ArgumentException("Invalid URL!");
    }
}

