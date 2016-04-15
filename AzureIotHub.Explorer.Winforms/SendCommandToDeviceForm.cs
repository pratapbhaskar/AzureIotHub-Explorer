using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public partial class SendCommandToDeviceForm : Form
    {
        private readonly string deviceId;
        
        public SendCommandToDeviceForm(string deviceId)
        {
            InitializeComponent();
            this.deviceId = deviceId;
        }

        public async Task Initialize()
        {
            this.encodingList.DataSource = Enum.GetValues(typeof(Encodings));
            this.deviceList.DataSource =  (await IotHubManager.Instance.GetDevicesAsync())
                .Select(a=> a.Id).ToList();
            this.deviceList.SelectedText = deviceId;
        }

        public async void OnSendButtonClick(object sender, EventArgs e)
        {
            try
            {
                var encoding = GetSelectedEncoding();
                await IotHubManager.Instance.SendCommandAsync(this.deviceList.SelectedItem.ToString(),
                    this.commandText.Text, encoding);
                MessageBox.Show("Command sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private Encoding GetSelectedEncoding()
        {
            Encodings encoding;
            Enum.TryParse<Encodings>(this.encodingList.SelectedValue.ToString(), out encoding);
            Encoding e = null;

            switch (encoding)
            {
                case Encodings.ASCII:
                    e = Encoding.ASCII;
                    break;
                case Encodings.UTF8:
                    e = Encoding.UTF8;
                    break;
                case Encodings.UTF7:
                    e = Encoding.UTF7;
                    break;
                case Encodings.UTF32:
                    e = Encoding.UTF32;
                    break;
                default:
                    break;
            }
            return e;
        }
    }
}
