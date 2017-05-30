using System;
using System.IO;
using System.Net.Sockets;
using Testat2.Storage;

namespace Testat2.HttpServer
{
    internal class HttpHandler
    {

        private readonly TcpClient client;
        private readonly TrackDataStorage trackDataStorage;

        public HttpHandler(TcpClient acceptTcpClient, TrackDataStorage trackDataStorage)
        {
            this.client = acceptTcpClient;
            this.trackDataStorage = trackDataStorage;
        }

        public void Do()
        {
            var sr = new StreamReader(client.GetStream());
            var sw = new StreamWriter(client.GetStream());

            Console.Write("Request from: " +
                              client.Client.RemoteEndPoint);

            var fileContent = this.trackDataStorage.LoadHttpPageFromStorage();

            var request = sr.ReadLine();

            Console.WriteLine("\tRequested: " + request);

            var header = "HTTP/1.1 200 OK\n";
            header += "Server: FuckingShittingRobotServer 1.0\n";
            header += "Content-type: text/html\n";
            header += "Content-length: " + fileContent.Length + "\n\n";

            sw.Write(header + fileContent);
            sw.Flush();
            sw.Close();
            client.Close();
        }
    }
}
