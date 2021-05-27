using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccessoiresDetailPageView : ContentPage
    {
        public AccessoiresDetailPageView(string name, string type, ImageSource image)
        {
            InitializeComponent();
            AccessoiresName.Text = name;
            AccessoiresType.Text = type;
            AccessoiresImage.Source = image;
        }
    }
}