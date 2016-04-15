using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public partial class IotHubMessageViewerForm : Form
    {
        private bool isRuning;
        private CancellationTokenSource cts;
        private readonly IotHubManager iotHubManager;
        public IotHubMessageViewerForm(IotHubManager iotHubManager)
        {
            InitializeComponent();
            this.iotHubManager = iotHubManager;
            this.iotHubNametext.Text = iotHubManager.HostName;
        }

        private async void OnStartStopMessageToggleButtonClick(object sender, EventArgs e)
        {
            if (!isRuning)
            {
                this.cts = new CancellationTokenSource();
                isRuning = true;
                this.startStopButton.Text = "Stop";
                var consoleAdapter = new ListViewConsoleAdapter(this.messagesList);
                await iotHubManager.ReceiveMessageAsync(consoleAdapter, this.cts.Token);
            }
            else
            {
                this.cts.Cancel();
                this.startStopButton.Text = "Start";
                isRuning = false;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (cts != null)
                cts.Cancel();
            base.OnClosing(e);
        }
    }
}
