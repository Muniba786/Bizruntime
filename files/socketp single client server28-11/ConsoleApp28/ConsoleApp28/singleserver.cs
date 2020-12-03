using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp28
{
    public class SingleServer
    {
        public void ss()
        {
            TcpListener serverSocket = new TcpListener(8888);

            TcpClient clientsocket = default(TcpClient);
            serverSocket.Start();
            Console.WriteLine(" server started");
            clientsocket = serverSocket.AcceptTcpClient();
            Console.WriteLine("Accept the request from client");
            
            try
            {

                NetworkStream networkStream = clientsocket.GetStream();
                byte[] bytesFrom = new byte[1025];
                networkStream.Read(bytesFrom, 0, (int)bytesFrom.Length);
                string datafromclient = Encoding.ASCII.GetString(bytesFrom);
                Console.WriteLine("data from client " + datafromclient);
                byte[] sendbytes = Encoding.ASCII.GetBytes(datafromclient);
                networkStream.Write(sendbytes, 0, sendbytes.Length);
                networkStream.Flush();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
            clientsocket.Close();
            serverSocket.Stop();

        }
    }
}