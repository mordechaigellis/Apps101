namespace WinForms101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            txtMethod.Text = Util101.Util.GetTime();
        }
    }
}