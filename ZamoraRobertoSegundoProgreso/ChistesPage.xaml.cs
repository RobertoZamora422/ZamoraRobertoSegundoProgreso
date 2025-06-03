using System.Net.Http;
using System.Text.Json;
 
namespace ZamoraRobertoSegundoProgreso
{
    public partial class ChistesPage : ContentPage
    {
        private readonly HttpClient _httpClient;

        public ChistesPage(HttpClient httpClient = null)
        {
            InitializeComponent();
            _httpClient = httpClient ?? new HttpClient();
            LoadJoke();
        }

        private async void LoadJoke()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
                var joke = JsonSerializer.Deserialize<Joke>(response);
                chisteLabel.Text = $"{joke.Setup}\n\n{joke.Punchline}";
            }
            catch (Exception ex)
            {
                chisteLabel.Text = $"Error: {ex.Message}";
                await DisplayAlert("Error", "No se pudo cargar el chiste", "OK");
            }
        }

        private void OnNuevoChisteClicked(object sender, EventArgs e) => LoadJoke();
    }

    public class Joke
    {
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}