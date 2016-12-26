using Windows.UI.Xaml.Media;
using MHG.Sample.Dependency.CustomControls;
using MHG.Sample.Dependency.WinPhone.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;
using Color = Windows.UI.Color;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MHG.Sample.Dependency.WinPhone.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.PlaceholderText = "Xamarin WinPhone";
                Control.Background = new SolidColorBrush(Color.FromArgb(0,0,0,0));

                //Tüm event ve property'leri platforma göre düzenleyebiliyoruz.
                Control.GotFocus += Control_GotFocus;
                Control.LostFocus += Control_LostFocus;
            }
        }

        private void Control_LostFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Control.FontFamily = new FontFamily("Arial");
            Control.Text = "LostFocus oldum";
        }

        private void Control_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Control.FontFamily = new FontFamily("Arial");
            Control.Text = "GotFocus oldum";
        }
    }
}
