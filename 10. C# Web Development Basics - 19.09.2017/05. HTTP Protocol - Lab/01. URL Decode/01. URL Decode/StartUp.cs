namespace _01._URL_Decode
{
    using System;
    using System.Net;

    class Program
    {
        static void Main(string[] args)
        {
            string encodedUrl = Console.ReadLine();
            string decodedUrl = WebUtility.UrlDecode(encodedUrl);

            Console.WriteLine(decodedUrl);
        }
    }
}
