using PPP.Database;
using PPP.Models;
using PPP.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HearingAidsView
    {
        public HearingAidsView()
        {
            InitializeComponent();
            BindingContext = new HearingAidsViewModel(new HearingAidsRepo(new DatabaseConnection()));
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Hi;
            await Navigation.PushAsync(new HearingAidsDetailPageView(details.ProductionDisplayName, details.SapPartNumber, details.Image));

        }

    }
}