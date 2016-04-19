using System;
using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public partial class Connect : Form
    {
        private readonly IotHubManager iotHubManager;
        private readonly AzureConnections azureConnections;

        public Connect(IotHubManager iotHubManager)
        {
            InitializeComponent();
            this.iotHubManager = iotHubManager;
            azureConnections = new AzureConnections();

            this.comboBox1.DataSource = azureConnections.GetKeys();
            this.comboBox1.SelectedText = string.Empty;
        }

        private void OnConnectClick(object sender, EventArgs e)
        {
            try
            {
                iotHubManager.Initialize(connectionString.Text);
                azureConnections.AddConnectionString(this.comboBox1.Text,
                    connectionString.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnConnectionStringTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                this.comboBox1.Text = iotHubManager.GetHostName(this.connectionString.Text);
            }
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            this.connectionString.Text = azureConnections
                .GetConnectionStringForHostName(this.comboBox1.SelectedItem.ToString());
        }
    }
}
