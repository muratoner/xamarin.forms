using MHG.Sample.Templates;
using Xamarin.Forms;

namespace MHG.Sample
{
    public class MyCarousel : CarouselPage
    {
        public MyCarousel()
        {
            Children.Add(new Page1());
            Children.Add(new Page2());
        }
    }
}
