namespace KalkulatorRatalny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnLoginClicked(object sender, EventArgs e)
        {
            // Pobranie danych z pól wejściowych
            string name = nameEntry.Text;
            string email = emailEntry.Text;
        }
    }

}
