using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetworkAccessibility
{
    internal class PING
    {
        private Ping myPing;
        private PingOptions myPingOptions;
        private string data;
        private string myPath;
        private string myLogFile;
        private byte[] buffer;
        private int myLength;
        private DateTime CurrentTime;
        private StreamWriter myStream;
        private PingReply reply;
        public PING(string args)
        {
            myPing = new Ping();
            myPingOptions = new PingOptions();
            data = "icmp_send_request";
            myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myLogFile = @"\AccessLog.txt";
            buffer = Encoding.ASCII.GetBytes(data);
           // myLength = args.Count;
            myStream = new StreamWriter(myPath + myLogFile);
            CurrentTime = DateTime.Now;
        }

        public bool ShowAnswer(string args)
        {
            //for (int i = 0; i < myLength; i++)
            //{
                myPingOptions.DontFragment = false;
                reply = myPing.Send(args, 120, buffer, myPingOptions);
                if (reply.Status.ToString() == "Success")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            //}
            //return true;
        }
    }
}
