namespace FileTransferManager
{
    internal static class Program
    {
        public static string DestinationAddress
        {
            get
            {
                if (mainForm == null)
                    throw new Exception("Instance of 'mainForm' is null.");
                else 
                    return mainForm.DestinationIpText.Text;
            }
        }

        public static string SourcePath
        {
            get
            {
                if (mainForm == null)
                    throw new Exception("Instance of 'mainForm' is null.");
                else
                    return mainForm.SourcePathText.Text;
            }
        }

        public static string DestinationPath
        {
            get
            {
                if (mainForm == null)
                    throw new Exception("Instance of 'mainForm' is null.");
                else
                    return mainForm.DestinationPathText.Text;
            }
        }

        private static MainForm? mainForm;

        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            mainForm = new MainForm();
            Application.Run(mainForm);
        }

        public static void PrintToConsole(string text)
        {
            if (mainForm == null)
                throw new Exception("Instance of 'mainForm' is null.");

            if (mainForm.ConsoleText.InvokeRequired)
                mainForm.ConsoleText.Invoke(new Action(() => PrintToConsole(text)));
            else
                mainForm.ConsoleText.Items.Add('\n' + text);
        }
    }
}