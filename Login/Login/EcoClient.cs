using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Login
{
    class EcoClient
    {
        TcpClient client = null;
        public string Address { get; set; }
        public int Port { get; set;}
        public EcoClient(string Address, int Port)
        {
            this.Address = Address;
            this.Port = Port;
        }
        public string Send( string Id)
        {
            client = new TcpClient(Address, Port);
            NetworkStream stream = client.GetStream();
            string message = string.Format(@"GetPerInf|{0}|",Id);
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
            byte[] answer = new byte[256];
            StringBuilder response = new StringBuilder();
            int bytes = stream.Read(answer, 0, answer.Length);
            response.Append(Encoding.Unicode.GetString(answer, 0, bytes));
            string res = response.ToString();
            return res;
        }
    }
}
