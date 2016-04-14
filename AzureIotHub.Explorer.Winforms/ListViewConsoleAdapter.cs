using System.Windows.Forms;

namespace AzureIotHub.Explorer.Winforms
{
    public class ListViewConsoleAdapter : IConsoleAdapter
    {
        private readonly ListView _listView;
        public ListViewConsoleAdapter(ListView listView)
        {
            _listView = listView;
        }
        public void WriteLine(string write)
        {
            _listView.Items.Add(write);
        }
    }
}
