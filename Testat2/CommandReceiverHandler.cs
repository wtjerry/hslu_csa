using System.IO;
using System.Net.Sockets;

namespace Testat2
{
    internal class CommandReceiverHandler
    {
        private readonly TcpClient client;
        private readonly TrackStorage trackStorage;
        private readonly TrackRunner trackRunner;

        private const string StartIdentifier = "start";

        public CommandReceiverHandler(
            TcpClient client, 
            TrackStorage trackStorage, 
            TrackRunner trackRunner)
        {
            this.client = client;
            this.trackStorage = trackStorage;
            this.trackRunner = trackRunner;
        }

        internal void Handle()
        {
            var networkString = ReadStream();

            if (networkString.Equals(StartIdentifier))
            {
                this.trackRunner.ExecuteSavedTracks();
            }
            else
            {
                this.trackStorage.SaveTracks(networkString);
            }
        }

        private string ReadStream()
        {
            var networkStream = this.client.GetStream();
            var networkString = new StreamReader(networkStream).ReadToEnd();
            this.client.Close();
            return networkString;
        }
    }
}
