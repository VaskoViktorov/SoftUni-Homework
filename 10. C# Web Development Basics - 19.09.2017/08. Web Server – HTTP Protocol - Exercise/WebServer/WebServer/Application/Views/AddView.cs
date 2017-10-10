using System;
using System.IO;
using System.Text;
using WebServer.Server.Contracts;

namespace WebServer.Application.Views
{
    class AddView : IView
    {
        public string View()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(File.ReadAllText(@".\Application\Resources\add.html"));

            if (!File.Exists("cakes.txt"))
            {
                File.Create("cakes.txt");
            }
         
                string[] cakeArgs = File.ReadAllLines("cakes.txt");
                foreach (var cakeArg in cakeArgs)
                {
                    string[] cake = cakeArg.Split('@', StringSplitOptions.RemoveEmptyEntries);
                    string name = cake[0];
                    string price = cake[1];
                    sb.AppendLine($"<div>name: {name}</div>");
                    sb.AppendLine($"<div>price: {price}</div>");
                }
                     
            return sb.ToString();
        }
    }
}
