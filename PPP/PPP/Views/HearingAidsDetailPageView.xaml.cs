using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HearingAidsDetailPageView : ContentPage
    {
        public HearingAidsDetailPageView(string name, string sapNumber, ImageSource image)
        {
            InitializeComponent();
            HiType.Text = name;
            HiSapNumber.Text = sapNumber;
            HiImage.Source = image;
        }
    }
}