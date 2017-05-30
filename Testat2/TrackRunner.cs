using System.Collections.Generic;
using Testat2.Storage;
using Track = Testat2.Tracks.Track;

namespace Testat2
{
    internal class TrackRunner
    {
        private readonly TrackStorage trackStorage;
        private readonly TrackCreator trackCreator;
        private readonly TrackExecutor trackExecutor;

        internal TrackRunner(
            TrackStorage trackStorage, 
            TrackCreator trackCreator, 
            TrackExecutor trackExecutor)
        {
            this.trackStorage = trackStorage;
            this.trackCreator = trackCreator;
            this.trackExecutor = trackExecutor;
        }

        internal void ExecuteSavedTracks()
        {
            var tracksAsSring = this.trackStorage.LoadTracks();
            var tracks = this.ConvertStringToTracks(tracksAsSring);
            var trackData = this.trackExecutor.ExecuteTracks(tracks);
            // todo jeremy: save trackdata to file
        }

        private IEnumerable<Track> ConvertStringToTracks(string tracksAsSring)
        {
            var tracksAsStringList = tracksAsSring
                .Replace("\r", "")
                .Split('\n');

            var tracks = new List<Track>();
            foreach (var s in tracksAsStringList)
            {
                var track = this.trackCreator.CreateTrack(s);
                tracks.Add(track);
            }

            return tracks;
        }
    }
}