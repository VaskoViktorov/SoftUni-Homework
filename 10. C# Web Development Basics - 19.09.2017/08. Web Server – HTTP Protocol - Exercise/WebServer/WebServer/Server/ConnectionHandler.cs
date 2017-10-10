namespace WebServer.Server
{
    using System;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    using Common;
    using Handlers;
    using HTTP;
    using Routing.Contracts;
    using HTTP.Contracts;

    public class ConnectionHandler
    {
        private readonly Socket client;

        private readonly IServerRouteConfig serverRouteConfig;

        public ConnectionHandler(Socket client, IServerRouteConfig serverRouteConfig)
        {
            CoreValidator.ThrowIfNull(client, nameof(client));
            CoreValidator.ThrowIfNull(serverRouteConfig, nameof(serverRouteConfig));

            this.client = client;
            this.serverRouteConfig = serverRouteConfig;
        }

        public async Task ProcessRequestAsync()
        {
            IHttpRequest httpRequest = await this.ReadRequest();

            var httpContext = new HttpContext(httpRequest);

            var httpResponce = new HttpHandler(this.serverRouteConfig).Handle(httpContext);

            var responseBytes = Encoding.UTF8.GetBytes(httpResponce.ToString());

            var byteSegments = new ArraySegment<byte>(responseBytes);

            await this.client.SendAsync(byteSegments, SocketFlags.None);

            Console.WriteLine($"----REQUEST----");
            Console.WriteLine(httpRequest);
            Console.WriteLine($"----RESPONCE----");
            Console.WriteLine(httpResponce);

            this.client.Shutdown(SocketShutdown.Both);
        }

        private async Task<IHttpRequest> ReadRequest()
        {
            var result = new StringBuilder();

            var data = new ArraySegment<byte>(new byte[1024]);

            while (true)
            {
                int numBytesRead = await this.client.ReceiveAsync(data, SocketFlags.None);

                if (numBytesRead == 0)
                {
                    break;
                }

                var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numBytesRead);

                result.Append(bytesAsString);

                if (numBytesRead < 1024)
                {
                    break;
                }
            }

            return new HttpRequest(result.ToString());
        }
    }
}

