namespace FileTransferManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DestinationIpLabel = new Label();
            FolderBrowser = new FolderBrowserDialog();
            BrowseSourcePathButton = new Button();
            PingButton = new Button();
            SourcePathLavel = new Label();
            DestinationIpText = new TextBox();
            SourcePathText = new TextBox();
            ConsoleText = new ListBox();
            SendButton = new Button();
            DestinationPathText = new TextBox();
            DestinationPathLabel = new Label();
            BrowseDestinationPathButton = new Button();
            RecieveButton = new Button();
            SuspendLayout();
            // 
            // DestinationIpLabel
            // 
            DestinationIpLabel.AutoSize = true;
            DestinationIpLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DestinationIpLabel.ForeColor = SystemColors.ButtonFace;
            DestinationIpLabel.Location = new Point(29, 43);
            DestinationIpLabel.Name = "DestinationIpLabel";
            DestinationIpLabel.Size = new Size(128, 18);
            DestinationIpLabel.TabIndex = 1;
            DestinationIpLabel.Text = "Destination IP:";
            // 
            // BrowseSourcePathButton
            // 
            BrowseSourcePathButton.BackColor = Color.FromArgb(255, 192, 128);
            BrowseSourcePathButton.FlatAppearance.BorderSize = 0;
            BrowseSourcePathButton.FlatStyle = FlatStyle.Flat;
            BrowseSourcePathButton.Font = new Font("Consolas", 6.6F);
            BrowseSourcePathButton.Location = new Point(292, 78);
            BrowseSourcePathButton.Name = "BrowseSourcePathButton";
            BrowseSourcePathButton.Size = new Size(64, 20);
            BrowseSourcePathButton.TabIndex = 3;
            BrowseSourcePathButton.Text = "Browse";
            BrowseSourcePathButton.UseVisualStyleBackColor = false;
            BrowseSourcePathButton.Click += BrowseSourcePathButton_Click;
            // 
            // PingButton
            // 
            PingButton.BackColor = Color.FromArgb(255, 192, 128);
            PingButton.FlatAppearance.BorderSize = 0;
            PingButton.FlatStyle = FlatStyle.Flat;
            PingButton.Font = new Font("Consolas", 6.6F);
            PingButton.Location = new Point(292, 43);
            PingButton.Name = "PingButton";
            PingButton.Size = new Size(64, 20);
            PingButton.TabIndex = 4;
            PingButton.Text = "Ping";
            PingButton.UseVisualStyleBackColor = false;
            PingButton.Click += PingButton_Click;
            // 
            // SourcePathLavel
            // 
            SourcePathLavel.AutoSize = true;
            SourcePathLavel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SourcePathLavel.ForeColor = SystemColors.ButtonFace;
            SourcePathLavel.Location = new Point(29, 78);
            SourcePathLavel.Name = "SourcePathLavel";
            SourcePathLavel.Size = new Size(88, 18);
            SourcePathLavel.TabIndex = 3;
            SourcePathLavel.Text = "File path:";
            // 
            // DestinationIpText
            // 
            DestinationIpText.BackColor = Color.FromArgb(64, 64, 64);
            DestinationIpText.BorderStyle = BorderStyle.None;
            DestinationIpText.ForeColor = SystemColors.Window;
            DestinationIpText.Location = new Point(161, 43);
            DestinationIpText.MaxLength = 15;
            DestinationIpText.Name = "DestinationIpText";
            DestinationIpText.Size = new Size(125, 20);
            DestinationIpText.TabIndex = 6;
            DestinationIpText.WordWrap = false;
            // 
            // SourcePathText
            // 
            SourcePathText.BackColor = Color.FromArgb(64, 64, 64);
            SourcePathText.BorderStyle = BorderStyle.None;
            SourcePathText.ForeColor = SystemColors.Window;
            SourcePathText.Location = new Point(123, 78);
            SourcePathText.MaxLength = 15;
            SourcePathText.Name = "SourcePathText";
            SourcePathText.Size = new Size(163, 20);
            SourcePathText.TabIndex = 7;
            SourcePathText.WordWrap = false;
            // 
            // ConsoleText
            // 
            ConsoleText.BackColor = Color.FromArgb(64, 64, 64);
            ConsoleText.BorderStyle = BorderStyle.None;
            ConsoleText.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConsoleText.ForeColor = Color.Gray;
            ConsoleText.FormattingEnabled = true;
            ConsoleText.ItemHeight = 18;
            ConsoleText.Items.AddRange(new object[] { "Program initialized successfully" });
            ConsoleText.Location = new Point(29, 289);
            ConsoleText.Name = "ConsoleText";
            ConsoleText.ScrollAlwaysVisible = true;
            ConsoleText.Size = new Size(327, 126);
            ConsoleText.TabIndex = 8;
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.FromArgb(192, 255, 192);
            SendButton.FlatAppearance.BorderSize = 0;
            SendButton.FlatStyle = FlatStyle.Flat;
            SendButton.Font = new Font("Consolas", 6.6F);
            SendButton.Location = new Point(245, 114);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(111, 20);
            SendButton.TabIndex = 9;
            SendButton.Text = "Send file";
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += SendButton_Click;
            // 
            // DestinationPathText
            // 
            DestinationPathText.BackColor = Color.FromArgb(64, 64, 64);
            DestinationPathText.BorderStyle = BorderStyle.None;
            DestinationPathText.ForeColor = SystemColors.Window;
            DestinationPathText.Location = new Point(123, 180);
            DestinationPathText.MaxLength = 15;
            DestinationPathText.Name = "DestinationPathText";
            DestinationPathText.PlaceholderText = "(Optional)";
            DestinationPathText.Size = new Size(163, 20);
            DestinationPathText.TabIndex = 12;
            DestinationPathText.WordWrap = false;
            // 
            // DestinationPathLabel
            // 
            DestinationPathLabel.AutoSize = true;
            DestinationPathLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DestinationPathLabel.ForeColor = SystemColors.ButtonFace;
            DestinationPathLabel.Location = new Point(29, 180);
            DestinationPathLabel.Name = "DestinationPathLabel";
            DestinationPathLabel.Size = new Size(88, 18);
            DestinationPathLabel.TabIndex = 10;
            DestinationPathLabel.Text = "File path:";
            // 
            // BrowseDestinationPathButton
            // 
            BrowseDestinationPathButton.BackColor = Color.FromArgb(255, 192, 128);
            BrowseDestinationPathButton.FlatAppearance.BorderSize = 0;
            BrowseDestinationPathButton.FlatStyle = FlatStyle.Flat;
            BrowseDestinationPathButton.Font = new Font("Consolas", 6.6F);
            BrowseDestinationPathButton.Location = new Point(292, 180);
            BrowseDestinationPathButton.Name = "BrowseDestinationPathButton";
            BrowseDestinationPathButton.Size = new Size(64, 20);
            BrowseDestinationPathButton.TabIndex = 11;
            BrowseDestinationPathButton.Text = "Browse";
            BrowseDestinationPathButton.UseVisualStyleBackColor = false;
            BrowseDestinationPathButton.Click += BrowseDestinationPathButton_Click;
            // 
            // RecieveButton
            // 
            RecieveButton.BackColor = Color.FromArgb(192, 255, 192);
            RecieveButton.FlatAppearance.BorderSize = 0;
            RecieveButton.FlatStyle = FlatStyle.Flat;
            RecieveButton.Font = new Font("Consolas", 6.6F);
            RecieveButton.Location = new Point(245, 215);
            RecieveButton.Name = "RecieveButton";
            RecieveButton.Size = new Size(111, 20);
            RecieveButton.TabIndex = 13;
            RecieveButton.Text = "Recieve file";
            RecieveButton.UseVisualStyleBackColor = false;
            RecieveButton.Click += RecieveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(383, 450);
            Controls.Add(RecieveButton);
            Controls.Add(DestinationPathText);
            Controls.Add(DestinationPathLabel);
            Controls.Add(BrowseDestinationPathButton);
            Controls.Add(SendButton);
            Controls.Add(ConsoleText);
            Controls.Add(SourcePathText);
            Controls.Add(DestinationIpText);
            Controls.Add(SourcePathLavel);
            Controls.Add(PingButton);
            Controls.Add(BrowseSourcePathButton);
            Controls.Add(DestinationIpLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "File Transfer Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DestinationIpLabel;
        private FolderBrowserDialog FolderBrowser;
        private Button BrowseSourcePathButton;
        private Button PingButton;
        private Label SourcePathLavel;
        public ListBox ConsoleText;
        public TextBox DestinationIpText;
        private Button SendButton;
        private Label DestinationPathLabel;
        private Button BrowseDestinationPathButton;
        private Button RecieveButton;
        public TextBox DestinationPathText;
        public TextBox SourcePathText;
    }
}
