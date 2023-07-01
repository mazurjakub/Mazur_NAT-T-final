using System;
using System.Net;

namespace Mazur_NAT_T.Models
{
    class Client
    {
        public string IpAddress { get; set; }
        public string Port { get; set; }

        public IPEndPoint ClientEP { get; set; }

        public Client (string IpAddress, string Port)
        {
            this.IpAddress = IpAddress;
            this.Port = Port;
            ClientEP = new IPEndPoint(IPAddress.Parse(IpAddress), Int32.Parse(Port));
        }

    }
}
