using System.Net.Sockets;
using System.Net;
using System.Text;

namespace FileTransferManager
{
    internal class Server
    {
        private static TcpListener listener = new TcpListener(IPAddress.Any, 7777);
        private static volatile bool isListening = false;

        public static void GetFileAsync(string pathToSave)
        {
            Task.Run(() => GetFile(pathToSave));
        }

        private static void GetFile(string pathToSave)
        {
            string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (pathToSave.Length == 0)
            {
                pathToSave = Path.Combine(downloadsFolderPath, "Downloads");
                Program.PrintToConsole("Save path is set to default: " + pathToSave);
            }
            else
                Program.PrintToConsole("Save path: " + pathToSave);

            listener.Start();
            isListening = true;

            try
            {
                Program.PrintToConsole("Waiting for connection...");

                while (isListening)
                {
                    if (listener.Pending())
                    {
                        using (TcpClient client = listener.AcceptTcpClient())
                        using (NetworkStream stream = client.GetStream())
                        {
                            Program.PrintToConsole("Connection established");
                            ReceiveDirectory(stream, pathToSave);
                            Program.PrintToConsole("File received successfully");
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            finally
            {
                listener.Stop();
                Program.PrintToConsole("Listening for connection stopped");
            }
        }

        public static void StopGettingFiles()
        {
            isListening = false;
        }

        private static void ReceiveDirectory(NetworkStream stream, string pathToSave)
        {
            byte[] buffer = new byte[4096];
            int bytesRead;

            // read the directory name
            bytesRead = stream.Read(buffer, 0, sizeof(int));
            int directoryNameLength = BitConverter.ToInt32(buffer, 0);
            bytesRead = stream.Read(buffer, 0, directoryNameLength);
            string directoryName = Encoding.UTF8.GetString(buffer, 0, bytesRead);



            // create the directory if it doesn't exist
            Directory.CreateDirectory(Path.Combine(pathToSave, directoryName));

            // read and save files
            while ((bytesRead = stream.Read(buffer, 0, sizeof(int))) > 0)
            {
                int fileNameLength = BitConverter.ToInt32(buffer, 0);

                if (fileNameLength == 0)
                    break; // end of directory marker

                bytesRead = stream.Read(buffer, 0, fileNameLength);
                string fileName = Path.Combine(pathToSave, directoryName, Encoding.UTF8.GetString(buffer, 0, bytesRead));

                // read file content
                using (FileStream fileStream = File.Create(fileName))
                {
                    bytesRead = stream.Read(buffer, 0, sizeof(int));
                    int fileSize = BitConverter.ToInt32(buffer, 0);

                    while (fileSize > 0 && (bytesRead = stream.Read(buffer, 0, Math.Min(buffer.Length, fileSize))) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                        fileSize -= bytesRead;
                    }
                }
            }
        }
    }
}
