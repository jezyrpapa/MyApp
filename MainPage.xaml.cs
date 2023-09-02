namespace MyFirstApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            btn1.Text = "10";
            btn10.Text = "1";

        }
    }
}