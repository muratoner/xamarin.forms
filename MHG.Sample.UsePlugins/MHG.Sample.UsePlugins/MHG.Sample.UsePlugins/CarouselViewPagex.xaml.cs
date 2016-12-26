using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MHG.Sample.UsePlugins
{
    public partial class CarouselViewPage: ContentPage
    {
        public CarouselViewPage()
        {
            InitializeComponent();

            CarouselView.ItemsSource = new[] {new {Name = "Murat"}, new { Name = "Hakan" }, new { Name = "Orhan" }};
            CarouselView.ItemSelected += CarouselView_ItemSelected;
        }

        private void CarouselView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var url = new WebView();
            url.Source = new UrlWebViewSource
            {
                Url = "http://www.muratoner.net"
            };
            var view = new ContentPage();
            view.Content = url;
            Navigation.PushAsync(view);
        }
    }
}
