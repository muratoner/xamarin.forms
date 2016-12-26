using MHG.Sample.CarouselView.Helpers;
using Xamarin.Forms;

namespace MHG.Sample.CarouselView
{
    public partial class CarouselPage : ContentPage
    {
        public CarouselPage()
        {
            InitializeComponent();

            CarouselZoos.ItemsSource = MonkeyHelper.Monkeys;
        }
    }
}
