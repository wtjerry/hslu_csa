using System.Net.Sockets;
using Testat2.Storage;

namespace Testat2.HttpServer {
    internal class SimpleHttpServer
    {
        private readonly TcpListener listener;
        private readonly TrackDataStorage trackDataStorage;
        private bool running = true;

        public SimpleHttpServer(TcpListener listener, TrackDataStorage trackDataStorage)
        {
            this.listener = listener;
            this.trackDataStorage = trackDataStorage;
        }

        public void Execute()
        {
            while (this.running)
            {
                var hh = new HttpHandler(this.listener.AcceptTcpClient(), this.trackDataStorage);
                hh.Do();
            }
        }

        public void Stop()
        {
            this.running = false;
        }
    }
}
