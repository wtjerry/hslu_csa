using System.Net.Sockets;

namespace Testat2.HttpServer {
    internal class SimpleHttpServer
    {
        private readonly TcpListener listener;
        private readonly string filepath;
        private bool running = true;

        public SimpleHttpServer(TcpListener listener, string filepath)
        {
            this.listener = listener;
            this.filepath = filepath;
        }

        public void Execute()
        {
            while (this.running)
            {
                var hh = new HttpHandler(this.listener.AcceptTcpClient(), this.filepath);
                hh.Do();
            }
        }

        public void Stop()
        {
            this.running = false;
        }
    }
}
