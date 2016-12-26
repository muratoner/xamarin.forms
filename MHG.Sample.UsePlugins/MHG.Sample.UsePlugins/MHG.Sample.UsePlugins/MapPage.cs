using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MHG.Sample.UsePlugins
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            CreateMap();
        }

        private async void CreateMap()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(10000);

            await DisplayAlert("Poziyon", $"Pozisyon Enlem: {position.Latitude}", "OK");
            await DisplayAlert("Poziyon", $"Pozisyon Boylam: {position.Longitude}", "OK");

            //Yeni bir instance alıyoruz ve kendi evimin konumunu ekliyorum.
            var currentMap = new Map(new MapSpan(new Position(position.Latitude, position.Longitude), 1, 1))
            {
                //Scroll edilebilsin
                HasScrollEnabled = true,
                //Zoom edilebilsin
                HasZoomEnabled = true,
                //Harita türü hibrid oluyor(satellite ve street karışımı)
                MapType = MapType.Street,
                //Telefonun bulunduğu yeri göster diyoruz
                IsShowingUser = true
            };

            //İstediğimiz konuma bu şekilde gidebiliyoruz.
            currentMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromMeters(100)));

            //Pin ekliyoruz
            var pin = new Pin
            {
                Position = new Position(40.7845523, 29.5468168),
                Address = "<b>Kayapınar mah.</b> <br>eynarca cad. no:44",
                Label = "Evim Evim Güzel Evim",
                Type = PinType.Place
            };

            //Pine tıklama event'i ekledik.
            pin.Clicked += Pin_Clicked;

            //Oluşturduğumuz pini haritaya ekliyoruz.
            currentMap.Pins.Add(pin);

            //Sayfanın content'ine mapi set ettik.
            Content = currentMap;
        }

        private void Pin_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Evime tıkladın", "Evime neden tıkladın", "OK");
        }
    }
}
