namespace Testat2.HttpServer
{
    internal class HttpPageCreator
    {
        private const string Headline = "Dane Wicki, Jeremy Meier";

        internal string Create(string receivedTracks, string trackData)
        {
            var page = $"{Headline}<br>{receivedTracks}<br>{trackData}";
            return page;
        }
    }
}
