using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public class ListViewConsoleAdapter : IConsoleAdapter
    {
        private readonly ListBox _listView;
        public ListViewConsoleAdapter(ListBox listView)
        {
            _listView = listView;
        }
        public void WriteLine(string write)
        {
            _listView.Items.Add(write);
        }
    }
}
