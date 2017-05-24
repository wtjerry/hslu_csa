using System.IO;

namespace Testat2
{
    internal class TrackStorage
    {
        internal const string TempTracklistFilePath = "\\Temp\\trackList";

        internal void SaveTracks(string tracks)
        {
            var fileStream = File.Create(TempTracklistFilePath);
            var fileStreamWriter = new StreamWriter(fileStream);
            fileStreamWriter.Write(tracks);
        }

        internal string LoadTracks()
        {
            var fileStream = File.OpenRead(TempTracklistFilePath);
            var streamReader = new StreamReader(fileStream);
            var tracks = streamReader.ReadToEnd();
            return tracks;
        }
    }
}