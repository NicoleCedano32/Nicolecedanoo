using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TuApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // Este método conecta el código con el XAML.
        }

        private async void OnLinkedInClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.linkedin.com/in/nicolecedanogrullon/");
        }

        private async void OnTwitterClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://twitter.com/nicolecedano/");
        }

        private async void OnFacebookClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.facebook.com/nicole.cedanogrullon?mibextid=LQQJ4d");
        }

        private async void OnYouTubeClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://youtube.com/@nicolecedanogrullon350?si=9C2Nuc1ecTm_6Aoq");
        }

        private async void OnInstagramClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.instagram.com/nicole_cedxno_?igsh=YWpyNmVoaTFmcGZ0");
        }
    }
}