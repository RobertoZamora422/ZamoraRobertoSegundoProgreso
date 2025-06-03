using Microsoft.Maui.Controls;
using System;

using Microsoft.Maui.Controls;
 
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
            await Navigation.PushAsync(new ChistesPage());
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}