using System.IO;
using Testat2.HttpServer;

namespace Testat2.Storage
{
    internal class TrackDataStorage
    {
        internal const string TempTrackDataHttpPage = "\\Temp\\trackDataHttpPage";

        private readonly HttpPageCreator httpPageCreator;

        internal TrackDataStorage(HttpPageCreator httpPageCreator)
        {
            this.httpPageCreator = httpPageCreator;
        }

        internal void SaveTrackData(string trackData, string tracks)
        {
            var httpPage = this.httpPageCreator.Create(tracks, trackData);

            var fileStream = File.Create(TempTrackDataHttpPage);
            var fileStreamWriter = new StreamWriter(fileStream);
            fileStreamWriter.Write(httpPage);
        }

        internal string LoadHttpPageFromStorage()
        {
            var page = "page is empty";
            if (File.Exists(TempTrackDataHttpPage))
            {
                var fileStream = File.OpenRead(TempTrackDataHttpPage);
                var streamReader = new StreamReader(fileStream);
                page = streamReader.ReadToEnd();
            }
            return page;
        }
    }
}