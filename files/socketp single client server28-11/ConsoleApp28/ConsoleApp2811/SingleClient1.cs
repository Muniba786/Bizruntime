/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2811
{

    public class SingleClient1
    {


        public void sc()
        {
            try
            {
                TcpClient tcpClient = new TcpClient();

                Console.WriteLine("");
                tcpClient.Connect("127.0.0.1",8888);
                Console.WriteLine("connected");
                Console.WriteLine("Enter the string");
                String data = Console.ReadLine();
                NetworkStream networkStream = tcpClient.GetStream();

                byte[] bytesdata = Encoding.ASCII.GetBytes(data);
                int datalength = (int)bytesdata.Length;
                networkStream.Write(bytesdata, 0, datalength);
                networkStream.Flush();

                byte[] inStream = new byte[10025];
                int reclength = (int)inStream.Length;
                networkStream.Read(inStream, 0, reclength);
                string returndata = Encoding.ASCII.GetString(inStream);
                Console.WriteLine("data from server" + returndata);

                tcpClient.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..." + e.StackTrace);
            }
        }
    }

}







  Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

   IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1994);
   sck.Connect(endpoint);
   Console.Write("Ener Message: ");
   string msg = Console.ReadLine();
   byte[] msgBuffer = Encoding.Default.GetBytes(msg);
   sck.Send(msgBuffer, 0, msgBuffer.Length, 0);

   byte[] buffer = new byte[225];
   int rec = sck.Recieve(buffer, 0, buffer.Length, 0);
   Array.Resize(ref buffer, rec);

   Console.WriteLine("Recieved: {0}", Encoding.Default.GetString(buffer));
   Console.Read();
} } }*/

















