using System;
using System.IO;

namespace LoggingTester
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            log.Info("Hello logging world!");
            log.Error("Error!");

            try
            {
                File.ReadAllLines("r:\\sdd\\text.txt");
            }
            catch (Exception ex)
            {
                log.Error("Exception handling", ex);
            }

            //Task.Run(() =>
            //{
            //    IPEndPoint remoteEndPoint = new IPEndPoint(127001, 5960);
            //    try
            //    {
            //        var udpClient = new UdpClient(5960);

            //        while (true)
            //        {
            //            var buffer = udpClient.Receive(ref remoteEndPoint);
            //            var loggingEvent = System.Text.Encoding.UTF8.GetString(buffer);
            //            Console.WriteLine(loggingEvent);
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.ToString());
            //    }

            //});
            //var udpClient = new UdpClient();
            //var loggingEvent = System.Text.Encoding.UTF8.GetBytes("test");
            //udpClient.Send(loggingEvent, loggingEvent.Length, "localhost", 5960);
        }
    }
}
