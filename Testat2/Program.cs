using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
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
                new Thread(new CommandReceiverHandler(listen.AcceptTcpClient(), robot).Do).Start();
            }
        }
    }
}