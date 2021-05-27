using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            webView.Source = "file:///android_asset/index.html";
        }

        private void WebviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.StartsWith("file://"))
            {
                return;
            }
            Device.OpenUri(new Uri(e.Url));
            e.Cancel = true;
        }
    }
}