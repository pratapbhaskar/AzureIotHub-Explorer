using System;
using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public partial class ConnectionStringWindow : Form
    {
        public ConnectionStringWindow(string connectionStringText)
        {
            InitializeComponent();
            this.label1.Text = connectionStringText;
        }

        private void OnCopyToClipBoardButtonClick(object sender, EventArgs e)
        {
            Clipboard.SetText(this.label1.Text);
            MessageBox.Show("Copied to clipboard");
            this.Close();
        }
    }
}
