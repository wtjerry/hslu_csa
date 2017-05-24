using System;
using System.Collections.Generic;
using RobotCtrl;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    internal class SavedTracksExecutor
    {
        private readonly TrackStorage trackStorage;
        private readonly Robot robot;
        private readonly TrackCreator trackCreator;

        internal SavedTracksExecutor(TrackStorage trackStorage, TrackCreator trackCreator, Robot robot)
        {
            this.trackStorage = trackStorage;
            this.robot = robot;
            this.trackCreator = trackCreator;
        }

        internal void ExecuteSavedTracks()
        {
            var tracksAsSring = this.trackStorage.LoadTracks();

            var tracksAsStringList = tracksAsSring.Replace("\r", "").Split('\n');
            var tracks = this.ConvertStringToTracks(tracksAsStringList);

            this.ExecuteTracks(tracks);
        }

        private IEnumerable<Track> ConvertStringToTracks(IEnumerable<string> commandsAsString)
        {
            var tracks = new List<Track>();
            foreach (var s in commandsAsString)
            {
                var track = this.trackCreator.CreateTrack(s);
                tracks.Add(track);
            }

            return tracks;
        }

        private void ExecuteTracks(IEnumerable<Track> tracks)
        {
            this.InitializeMotor();

            foreach (var track in tracks)
            {
                Console.WriteLine("RunSync started");
                track.RunSync();
                Console.WriteLine("RunSync ended");
            }
        }

        private void InitializeMotor()
        {
            this.robot.Position = new PositionInfo(0, 0, 0);
            this.robot.Drive.DriveCtrl.PowerLeft = true;
            this.robot.Drive.DriveCtrl.PowerRight = true;
        }
    }
}