using System.IO;

namespace Testat2.Storage
{
    internal class TrackStorage
    {
        private const string TempTracklistFilePath = "\\Temp\\trackList";

        internal void SaveTracks(string tracks)
        {
            var fileStream = File.Create(TempTracklistFilePath);
            var fileStreamWriter = new StreamWriter(fileStream);
            fileStreamWriter.Write(tracks);

            fileStreamWriter.Flush();
            fileStream.Flush();

            fileStreamWriter.Close();
            fileStream.Close();
        }

        internal string LoadTracks()
        {
            var fileStream = File.OpenRead(TempTracklistFilePath);
            var streamReader = new StreamReader(fileStream);
            var tracks = streamReader.ReadToEnd();

            streamReader.Close();
            fileStream.Close();

            return tracks;
        }
    }
}