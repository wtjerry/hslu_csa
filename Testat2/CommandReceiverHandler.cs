using System.IO;
using System.Net.Sockets;

namespace Testat2
{
    class CommandReceiverHandler
    {
        private readonly TcpClient client;
        private readonly TrackStorage trackStorage;
        private readonly SavedTracksExecutor savedTracksExecutor;

        private const string StartIdentifier = "start";

        public CommandReceiverHandler(
            TcpClient client, 
            TrackStorage trackStorage, 
            SavedTracksExecutor savedTracksExecutor)
        {
            this.client = client;
            this.trackStorage = trackStorage;
            this.savedTracksExecutor = savedTracksExecutor;
        }

        public void Do()
        {
            var networkString = ReadStream();

            if (networkString.Equals(StartIdentifier))
            {
                this.savedTracksExecutor.ExecuteSavedTracks();
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
