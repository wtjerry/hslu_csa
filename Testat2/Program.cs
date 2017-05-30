using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using RobotCtrl;
using Testat2.HttpServer;
using Testat2.Storage;

namespace Testat2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            StartTrackDataProviderAsync();
            RunTrackListenerBlocking();
        }

        private static void RunTrackListenerBlocking()
        {
            var listen = new TcpListener(IPAddress.Any, 34343);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " +
                                  listen.LocalEndpoint + "...");

                var robot = new Robot();
                var trackStorage = new TrackStorage();
                var obstacleDetector = new ObstacleDetector(robot);
                var trackFactory = new TrackFactory(robot, obstacleDetector);
                var trackCreator = new TrackCreator(trackFactory);
                var trackExecutor = new TrackExecutor(robot);
                var savedTracksExecutor = new TrackRunner(trackStorage, trackCreator, trackExecutor);
                var tcpClient = listen.AcceptTcpClient();
                var commandReceiverHandler = new CommandReceiverHandler(tcpClient, trackStorage, savedTracksExecutor);
                new Thread(commandReceiverHandler.Handle).Start();
            }
        }

        private static void StartTrackDataProviderAsync()
        {
            var listen = new TcpListener(IPAddress.Any, 8080);
            listen.Start();
            Console.WriteLine("Warte auf Verbindung auf Port " +
                                listen.LocalEndpoint + "...");

            var simpleHttpServer = new SimpleHttpServer(listen, TrackDataStorage.TempTracklistFilePath);
            new Thread(simpleHttpServer.Execute).Start();
        }
    }
}