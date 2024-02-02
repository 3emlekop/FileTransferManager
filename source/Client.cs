using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace FileTransferManager
{
    internal class Client
    {
        public static bool Ping(string address)
        {
            IPAddress? ipAddress;
            int ipNumber;
            if (IPAddress.TryParse(address, out ipAddress) == false || int.TryParse(address, out ipNumber))
            {
                Program.PrintToConsole("Couldn't reach given address: " + address);
                return false;
            }

            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(address);

            if (reply.Status == IPStatus.Success)
            {
                Program.PrintToConsole($"Ping to {address} was successful");
                Program.PrintToConsole($"Response time: {reply.RoundtripTime} ms");
                return true;
            }
            else
            {
                Program.PrintToConsole($"Ping to {address} failed");
                Program.PrintToConsole($"Status: {reply.Status}");
                return false;
            }
        }

        public static void SendFile(string address, string filePath)
        {

            TcpClient client = new TcpClient(address, 7777);
            using (NetworkStream stream = client.GetStream())
            {
                Program.PrintToConsole($"Sending file:");
                Program.PrintToConsole($"File name: {Path.GetFileName(filePath)}");
                Program.PrintToConsole($"IPv4 Address/Port: {address}:7777");
                SendDirectory(stream, filePath);
            }
            client.Close();
            Program.PrintToConsole("File sent successfully");
        }

        private static void SendDirectory(NetworkStream stream, string filePath)
        {
            byte[] buffer = new byte[4096];

            // send directory name
            byte[] directoryNameBytes = Encoding.UTF8.GetBytes(filePath);
            stream.Write(BitConverter.GetBytes(directoryNameBytes.Length), 0, sizeof(int));
            stream.Write(directoryNameBytes, 0, directoryNameBytes.Length);

            foreach (string path in Directory.GetFiles(filePath))
            {
                // send file name
                string fileName = Path.GetFileName(path);
                byte[] fileNameBytes = Encoding.UTF8.GetBytes(fileName);
                stream.Write(BitConverter.GetBytes(fileNameBytes.Length), 0, sizeof(int));
                stream.Write(fileNameBytes, 0, fileNameBytes.Length);

                // send file content
                byte[] fileContent = File.ReadAllBytes(path);
                stream.Write(BitConverter.GetBytes(fileContent.Length), 0, sizeof(int));
                stream.Write(fileContent, 0, fileContent.Length);
            }
            //send the end of directory marker
            stream.Write(BitConverter.GetBytes(0), 0, sizeof(int));
        }
    }
}
