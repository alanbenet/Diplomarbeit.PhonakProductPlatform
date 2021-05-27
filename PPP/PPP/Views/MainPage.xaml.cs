using Plugin.Connectivity;
using System;
using Xamarin.Forms.Xaml;

namespace PPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : IDisposable
    {
        public MainPage()
        {
            InitializeComponent();
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

        }

        private async void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            if (!e.IsConnected)
            {
                await DisplayAlert("Error", "Check your connection.", "Ok");
            }
        }

        public void Dispose()
        {
            CrossConnectivity.Current.ConnectivityChanged -= Current_ConnectivityChanged;
        }
    }
}