using PPP.Models;
using System;
using PPP.Database;
using PPP.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccessoiresView : ContentPage
    {

        public AccessoiresView()
        {
            InitializeComponent();
            BindingContext = new AccessoiresViewModel(new AccessoryRepo(new DatabaseConnection()));
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Accessory;
            await Navigation.PushAsync(new AccessoiresDetailPageView(details.ProductionDisplayName, details.SapPartNumber, details.Image));

        }
    }
}