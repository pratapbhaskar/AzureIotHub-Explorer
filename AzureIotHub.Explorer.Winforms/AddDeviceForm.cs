using System;
using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public partial class AddDeviceForm : Form
    {
        private readonly IotHubManager iotHubManager;
        public AddDeviceForm(IotHubManager iotHubManager)
        {
            InitializeComponent();
            this.iotHubManager = iotHubManager;
        }

        private async void OnAddDeviceButtonClick(object sender, EventArgs e)
        {
            try
            {
                await iotHubManager.AddDeviceAsync(this.textBox1.Text);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
            }
            
        }
    }
}
