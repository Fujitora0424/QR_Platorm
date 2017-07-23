using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QR_Tool_Winform.Tcp
{
    class _TCPClient
    {
        public TcpClient m_client = new TcpClient();

        public void Connect(string address, int port)
        {
            if (m_client.Connected)
                throw new Exception("Connect: Already connected");

            m_client.Connect(address, port);
        }

        public void WriteBytes(byte[] data)
        {
          
            // Get access to network stream
            Stream stm = m_client.GetStream();
            stm.Write(data, 0, data.Length);

        }

        public byte[]  ReadAllBytes()
        {

            using (MemoryStream ms = new MemoryStream())
            {
                m_client.GetStream().CopyTo(ms);
                return ms.ToArray();
            }

        }

        public void CloseDppClient()
        {
            if (m_client.Connected)
            {
                m_client.GetStream().Close();
                m_client.Close();
            }
        }
    }
}
