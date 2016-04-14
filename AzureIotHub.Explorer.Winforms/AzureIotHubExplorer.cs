using System;
using System.Threading;
using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public partial class AzureIotHubExplorer : Form
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        private bool isRuning = false;
        public AzureIotHubExplorer()
        {
            InitializeComponent();
        }

        private async void AzureIotHubExplorer_Load(object sender, EventArgs e)
        {
            if (!IotHubManager.Instance.HasBeenInitialized)
            {
                toolStripStatusLabel1.Text = "Connecting to Azure IotHub....";
                var result = new Connect().ShowDialog();
                Show();

                toolStripStatusLabel1.Text = "Connected to Azure Iothub with name " ;

                this.deviceModelBindingSource.DataSource = await
                    IotHubManager.Instance.GetDevicesAsync();
                this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                
            }
        }
        
        private async void OnStartStopToggleButtonClick(object sender, EventArgs e)
        {
            if (!isRuning)
            {
                isRuning = true;
                this.button1.Text = "Stop";
                var consoleAdapter = new ListViewConsoleAdapter(this.listView1);
                await IotHubManager.Instance.ReceiveMessageAsync(consoleAdapter, this.cts.Token);
            }
            else
            {
                this.cts.Cancel();
                this.button1.Text = "Start";
            }
        }

        private void OnDataGridViewMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hti.RowIndex].Selected = true;
            }
        }


        private async void OnGenerateConnectionStringClick(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            var deviceId = dataGridView1.Rows[selectedRow].Cells["idColumn"].Value.ToString();

            var connectionStringWindow = new ConnectionStringWindow(await IotHubManager.Instance.GetConnectionString(deviceId));
            connectionStringWindow.ShowDialog();
        }

        private void OnAddDeviceClick(object sender, EventArgs e)
        {
            
        }
    }
}
