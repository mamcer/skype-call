using Microsoft.AspNet.SignalR.Client.Hubs;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using ConnectionState = Microsoft.AspNet.SignalR.Client.ConnectionState;

namespace SkypeCall.Handler
{
    public partial class Main : Form
    {
        private IHubProxy _skypeCallHub;

        public Main()
        {
            InitializeComponent();
        }

        private async void InitializeSignalR(string url)
        {
            WriteLogMessage("Initializing SignalR connection...");
            var hubConnection = new HubConnection(url);
            _skypeCallHub = hubConnection.CreateHubProxy("skypeCallHub");

            _skypeCallHub.On<string>("SkypeCallRequest", userName =>
                {
                    try
                    {
                        _skypeCallHub.Invoke("clientNotification", DateTime.Now.ToString("HH:mm:ss") + " - processing request...");
                        WriteLogMessage($"Request received. User: {userName}");
                        Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", "skype:" + userName + "?call&video=true");
                        _skypeCallHub.Invoke("clientNotification",  DateTime.Now.ToString("HH:mm:ss") + " - request successfully processed. User:  " + userName );
                    }
                    catch (Exception ex)
                    {
                        WriteLogMessage("An error has occurred: " + ex.Message);
                    }
                });

            await hubConnection.Start();
            WriteLogMessage(hubConnection.State != ConnectionState.Connected
                                ? "Connection couldn't be established."
                                : "Connection established.");
        }

        private void WriteLogMessage(string message)
        {
            lstConsole.Items.Add($"{DateTime.Now:HH:mm:ss} - {message}");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            InitializeSignalR(txtUrl.Text);
        }
    }
}