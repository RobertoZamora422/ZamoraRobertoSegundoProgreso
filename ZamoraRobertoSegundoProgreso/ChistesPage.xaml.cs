using System;
using System.Net.Http;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace ZamoraRobertoSegundoProgreso;

public partial class ChistesPage : ContentPage
{
    private readonly HttpClient _httpClient = new HttpClient();
    public ChistesPage()
	{
		InitializeComponent();
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
            chisteLabel.Text = $"Error al cargar el chiste: {ex.Message}";
        }
    }

    private void OnVolverClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    public class Joke
    {
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}