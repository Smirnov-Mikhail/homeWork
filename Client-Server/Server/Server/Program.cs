namespace Server
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    class ExampleTcpListener
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            Int32 port = 9595;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            server = new TcpListener(localAddr, port);
            server.Start();

            UInt32 counter = 0;
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");

                ThreadPool.QueueUserWorkItem(ProcessingRequest, server.AcceptTcpClient());
                Console.WriteLine("Connection №" + (++counter).ToString());
            }
        }

        static void ProcessingRequest(object client_obj)
        {
            Byte[] buffer = new Byte[256];

            TcpClient client = client_obj as TcpClient;

            NetworkStream stream = client.GetStream();

            Int32 i;
            while ((i = stream.Read(buffer, 0, buffer.Length)) != 0)
            {
                String data = System.Text.Encoding.ASCII.GetString(buffer, 0, i);

                if (data == "close")
                {
                    Console.WriteLine("Close the connection");
                    break;
                }
                else
                {
                    // Do something with the data.
                    data = new string(data.Reverse().ToArray());

                    Byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                    stream.Write(msg, 0, msg.Length);
                }
            }

            client.Close();
        }
    }
}
