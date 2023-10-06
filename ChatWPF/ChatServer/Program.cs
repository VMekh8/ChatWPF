using ChatServer.Net.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Program
    {
        static TcpListener _listener;
        static List<Client> _users;

        static void Main(string[] args)
        {
            _users = new List<Client>();
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7891);
            _listener.Start();
           
            while(true)
            {
            var client = new Client(_listener.AcceptTcpClient());
                _users.Add(client);
                BroadCastConnection();
            }
            
        }

        static void BroadCastConnection()
        {
            foreach (var user in _users)
            {
                foreach(var usr in _users)
                {
                    var broadcastpacket = new PacketBuilder();
                    broadcastpacket.WriteOpCode(1);
                    broadcastpacket.WriteMessage(usr.Username);
                    broadcastpacket.WriteMessage(usr.UID.ToString());
                    user.ClientSocket.Client.Send(broadcastpacket.GetPacketBytes());
                }
            }
        }

    }
}
