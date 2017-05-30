using System;
using System.IO;
using System.Net.Sockets;

namespace Testat2.HttpServer
{
    internal class HttpHandler
    {

        private readonly TcpClient client;
        private readonly string filepath;

        public HttpHandler(TcpClient acceptTcpClient, string filepath)
        {
            this.client = acceptTcpClient;
            this.filepath = filepath;
        }

        public void Do()
        {
            var sr = new StreamReader(client.GetStream());
            var sw = new StreamWriter(client.GetStream());

            Console.Write("Request from: " +
                              client.Client.RemoteEndPoint);

            var fileContent = "File not Found!";
            if(File.Exists(this.filepath))
            {
                fileContent = File.OpenText(this.filepath).ReadToEnd();
            }

            var request = sr.ReadLine();

            Console.WriteLine("\tRequested: " + request);

            var header = "HTTP/1.1 200 OK\n";
            header += "Server: FuckingShittingRobotServer 1.0\n";
            header += "Content-type: text/plain\n";
            header += "Content-length: " + fileContent.Length + "\n\n";

            sw.Write(header + fileContent);
            sw.Flush();
            sw.Close();
            client.Close();
        }
    }
}
