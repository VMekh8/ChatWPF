using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Net.IO
{
    class PacketBuilder
    {
        MemoryStream _ms;
        public PacketBuilder()
        {
            _ms = new MemoryStream();
        }

        public void WriteOpCode(byte opcode)
        {
            _ms.WriteByte(opcode);
        }

        public void WriteString(string msg)
        {
            byte[] lengthBytes = BitConverter.GetBytes(msg.Length);

            _ms.Write(lengthBytes, 0, lengthBytes.Length);

            byte[] messageBytes = Encoding.ASCII.GetBytes(msg);

            _ms.Write(messageBytes, 0, messageBytes.Length);
        }

        public byte[] GetPacketBytes()
        {
            return _ms.ToArray();
        }

    }
}
