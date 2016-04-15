using System;
using System.ComponentModel;
using System.Text;
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
                CleanupForCloseOrHide();
            }
        }

        private void CleanupForCloseOrHide()
        {
            if(cts != null)
                this.cts.Cancel();
            this.startStopButton.Text = "Start";
            isRuning = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            CleanupForCloseOrHide();
            base.OnClosing(e);
        }

        protected void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                CleanupForCloseOrHide();
                Hide();
            }
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();
            var listOfSelectedItems = this.messagesList.SelectedItems;
            foreach (var item in listOfSelectedItems)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            if(listOfSelectedItems.Count > 0)
                Clipboard.SetText(stringBuilder.ToString());
        }

        private void OnListBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
                OnCopyClick(sender, e);
        }
    }
}
