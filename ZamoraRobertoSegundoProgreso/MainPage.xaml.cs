using Microsoft.Maui.Controls;
using System;

namespace ZamoraRobertoSegundoProgreso
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnChistesClicked(object sender, EventArgs e)
        {
            try
            {
                var chistesPage = Handler.MauiContext.Services.GetService<ChistesPage>();

                if (chistesPage != null)
                {
                    await Navigation.PushAsync(chistesPage);
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo cargar la página de chistes.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurrió un error al intentar abrir la página de chistes: {ex.Message}", "OK");
            }
        }
    }
}