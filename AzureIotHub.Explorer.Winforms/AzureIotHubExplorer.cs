using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public partial class AzureIotHubExplorer : Form
    {
        private IotHubMessageViewerForm messageViewer;
        private readonly IotHubManager iotHubManager;
        private System.Windows.Forms.Timer timer;

        public AzureIotHubExplorer()
        {
            InitializeComponent();
            iotHubManager = IotHubManager.Instance;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            if (!iotHubManager.HasBeenInitialized)
            {
                toolStripStatusLabel1.Text = "Connecting to Azure IotHub....";
                var result = new Connect(iotHubManager).ShowDialog();
                if (result != DialogResult.OK)
                {
                    System.Environment.Exit(1);
                }
                Show();

                toolStripStatusLabel1.Text = "Connected to Azure Iothub with name \"" + 
                    iotHubManager.HostName + "\"";

                await RefreshDeviceListAsync();
            }
        }

        private async Task RefreshDeviceListAsync()
        {
            this.deviceModelBindingSource1.DataSource = await
                    iotHubManager.GetDevicesAsync();
            this.deviceList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
   

        private void OnDataGridViewMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = deviceList.HitTest(e.X, e.Y);
                deviceList.ClearSelection();
                deviceList.Rows[hti.RowIndex].Selected = true;
            }
        }


        private async void OnGenerateConnectionStringClick(object sender, EventArgs e)
        {
            using (var connectionStringWindow = new ConnectionStringWindow
                (await iotHubManager.GetConnectionString(GetSelectedDeviceId())))
            {
                connectionStringWindow.ShowDialog();
            }
        }

        private async void OnAddDeviceClick(object sender, EventArgs e)
        {
            using(var addDeviceForm = new AddDeviceForm(iotHubManager))
            {
                addDeviceForm.ShowDialog();
                await RefreshDeviceListAsync();   
            }
        }

        private async void OnRemoveDeviceClick(object sender, EventArgs e)
        {
            await iotHubManager.RemoveDeviceAsync(GetSelectedDeviceId());
        }

        private string GetSelectedDeviceId()
        {
            var selectedRow = deviceList.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            return deviceList.Rows[selectedRow].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
        }

        private async void OnSendCommandToDevice(object sender, EventArgs e)
        {
            using(var sendCommand = new SendCommandToDeviceForm(GetSelectedDeviceId()))
            {
                await sendCommand.Initialize();
                sendCommand.ShowDialog();
            }
        }

        private void OnOpenMessageViewerButtonClick(object sender, EventArgs e)
        {
            if(messageViewer == null)
            {
                messageViewer = new IotHubMessageViewerForm(iotHubManager);
                messageViewer.Show();
            }
            else
            {
                messageViewer.Show();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (messageViewer != null)
                messageViewer.Close();
        }

        private void OnRefreshCheckChanged(object sender, EventArgs e)
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 60 * 1000;
                timer.Tick += OnTimerTick;
            }

            if (this.refreshCheckbox.Checked)
                timer.Start();
            else
                timer.Stop();
                
        }

        private async void OnTimerTick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            await RefreshDeviceListAsync();
            this.Cursor = Cursors.Default;
        }
    }
}
