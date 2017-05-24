using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using RobotCtrl;

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
            var listen = new TcpListener(IPAddress.Any, 34343);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " +
                    listen.LocalEndpoint + "...");

                var robot = new Robot();
                var trackStorage = new TrackStorage();
                var trackCreator = new TrackCreator(robot);
                var trackExecutor = new TrackExecutor(robot);
                var savedTracksExecutor = new TrackRunner(trackStorage, trackCreator, trackExecutor);
                var tcpClient = listen.AcceptTcpClient();
                var commandReceiverHandler = new CommandReceiverHandler(tcpClient, trackStorage, savedTracksExecutor);
                new Thread(commandReceiverHandler.Handle).Start();
            }
        }
    }
}