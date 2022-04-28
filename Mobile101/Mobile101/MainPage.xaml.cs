using System;
using Xamarin.Forms;
using Util101;

namespace Mobile101
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMethod_Clicked(object sender, EventArgs e)
        {
            lblDisplay.Text = Util.GetTime();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            txtEquation.Text += ((Button)sender).Text;
        }
    }
}
