using System;

namespace Testat2
{
    internal class HttpServer
    {
        private readonly HttpPageCreator httpPageCreator;

        public HttpServer(HttpPageCreator httpPageCreator)
        {
            this.httpPageCreator = httpPageCreator;
        }

        public void StartHttpServer(string tracksAsSring, string trackData)
        {
            var httpPage = this.httpPageCreator.Create(tracksAsSring, trackData);
            Console.Write(httpPage);
        }
    }
}