using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using RobotCtrl;
using Testat2.Tracks;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    class CommandReceiverHandler
    {
        private readonly TcpClient client;
        private readonly TrackStorage trackStorage;
        private readonly SavedTracksExecutor savedTracksExecutor;
        private readonly Robot robot;

        private const string TracklineCommandName = "TrackLine ";
        private const string TrackTurnLeftCommandName = "TrackTurnLeft ";
        private const string TrackTurnRightCommandName = "TrackTurnRight ";
        private const string TrackArcLeftCommandName = "TrackArcLeft ";
        private const string TrackArcRightCommandName = "TrackArcRight ";

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
