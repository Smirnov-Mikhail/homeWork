namespace ExampleTcpClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Enter the ip server:");
                Connect(Console.ReadLine());
            }
        }

        static void Connect(String server)
        {
            try
            {
                Int32 port = 9595;
                TcpClient client = new TcpClient(server, port);
                NetworkStream stream = client.GetStream();

                while (true)
                {
                    Console.WriteLine("Enter message:");
                    String message = Console.ReadLine();

                    Byte[] buffer = System.Text.Encoding.ASCII.GetBytes(message);

                    stream.Write(buffer, 0, buffer.Length);
                    Console.WriteLine("Sent: {0}", message);

                    if (message == "close")
                        break;

                    Int32 countBytes = stream.Read(buffer, 0, buffer.Length);
                    Console.WriteLine("Response: {0}", System.Text.Encoding.ASCII.GetString(buffer));
                }

                stream.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }
}
