﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _03._Simple_Web_Server
{
    public class Program
    {
       public static void Main()
       {
           var port = 1337;
           var ipAddress = IPAddress.Parse("127.0.0.1");
           var tcpListener = new TcpListener(ipAddress,port);

            tcpListener.Start();

           Console.WriteLine("Server started");
            Console.WriteLine($"Listening to TCP clients at 127.0.0.1:{port}");

            Task
                .Run(async () => await Connect(tcpListener))
            .GetAwaiter()
            .GetResult();
                    
       }

        public static async Task Connect(TcpListener listener)
        {
            while (true)
            {
                Console.WriteLine("Waiting for client...");
                var client = await listener.AcceptTcpClientAsync();

                Console.WriteLine("Client connected.");
                var buffer = new byte[1024];

                await client.GetStream().ReadAsync(buffer, 0, buffer.Length);

                var clientMessage = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(clientMessage.Trim('\0'));

                var responceMessage = "HTTP /1.1 200 OK\nContent-Type: text/plain\n\nHello from server";
                var data = Encoding.UTF8.GetBytes(responceMessage);

                await client.GetStream().WriteAsync(data, 0, data.Length);

                Console.WriteLine("Closing connection.");
                client.Dispose();
            }
        }
    }
}
