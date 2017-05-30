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
            var robot = new Robot();
            
            var trackDataStorage = new TrackDataStorage(new HttpPageCreator());
            StartTrackDataProviderAsync(trackDataStorage);
            new Thread(x => RunTrackListenerBlocking(trackDataStorage, robot)).Start();
            while (true)
            {
            }
        }

        private static void StartTrackDataProviderAsync(TrackDataStorage trackDataStorage)
        {
            var listen = new TcpListener(IPAddress.Any, 8080);
            listen.Start();
            Console.WriteLine("Warte auf Verbindung auf Port " +
                                listen.LocalEndpoint + "...");

            var simpleHttpServer = new SimpleHttpServer(listen, trackDataStorage);
            new Thread(simpleHttpServer.Execute).Start();
        }

        private static void RunTrackListenerBlocking(TrackDataStorage trackDataStorage, Robot robot)
        {
            var listen = new TcpListener(IPAddress.Any, 34343);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " +
                                  listen.LocalEndpoint + "...");
                var trackStorage = new TrackStorage();
                var obstacleDetector = new ObstacleDetector(robot);
                var trackFactory = new TrackFactory(robot, obstacleDetector);
                var trackCreator = new TrackCreator(trackFactory);
                var trackExecutor = new TrackExecutor(robot);
                var savedTracksExecutor = new TrackRunner(trackStorage, trackDataStorage, trackCreator, trackExecutor);
                var tcpClient = listen.AcceptTcpClient();
                var commandReceiverHandler = new CommandReceiverHandler(tcpClient, trackStorage, savedTracksExecutor);
                new Thread(commandReceiverHandler.Handle).Start();
            }
        }
    }
}