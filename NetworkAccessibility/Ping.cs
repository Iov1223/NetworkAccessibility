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
        private byte[] buffer;
        private PingReply reply;
        public PING()
        {
            myPing = new Ping();
            myPingOptions = new PingOptions();
            data = "icmp_send_request";
            buffer = Encoding.ASCII.GetBytes(data);
        }

        public bool ShowAnswer(string args)
        {
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
        }
    }
}
