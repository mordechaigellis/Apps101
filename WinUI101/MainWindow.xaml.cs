using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI101
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void btnMethod_Click(object sender, RoutedEventArgs e)
        {
            //txtMsg.Text = Util101.Util.GetTime();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += ((Button)sender).Content.ToString();
        }

        
    }
}
