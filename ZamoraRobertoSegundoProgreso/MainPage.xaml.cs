using ZamoraRobertoSegundoProgreso.Services;
namespace ZamoraRobertoSegundoProgreso
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnChistesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistesPage(
                MauiProgram.CreateMauiApp().Services.GetRequiredService<IChistesService>()));
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}