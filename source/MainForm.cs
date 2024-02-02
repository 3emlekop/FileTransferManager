namespace FileTransferManager
{
    public partial class MainForm : Form
    {
        private bool isRecieving = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PingButton_Click(object sender, EventArgs e)
        {
            if (Program.DestinationAddress.Length == 0)
                return;

            Client.Ping(Program.DestinationAddress);
        }

        private void BrowseSourcePathButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
                SourcePathText.Text = FolderBrowser.SelectedPath;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(Client.Ping(Program.DestinationAddress) == true)
                Client.SendFile(Program.DestinationAddress, Program.SourcePath);
        }

        private void RecieveButton_Click(object sender, EventArgs e)
        {
            if (isRecieving)
            {
                Server.StopGettingFiles();
                RecieveButton.Text = "Recieve file";
            }
            else
            {
                Server.GetFileAsync(Program.DestinationPath);
                RecieveButton.Text = "Stop recieving";

            }

            isRecieving = !isRecieving;
        }

        private void BrowseDestinationPathButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
                DestinationPathText.Text = FolderBrowser.SelectedPath;
        }
    }
}
