namespace KalkulatorRatalny
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void OnNadplataToggled(object sender, ToggledEventArgs e)
        {
            bool isSwitchOn = e.Value;

            nadplataKredytuLabel.IsVisible = isSwitchOn;
            nadplataKredytuInput.IsVisible = isSwitchOn;
        }
    }
}
