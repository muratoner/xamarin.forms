using MHG.Sample.Dependency.CustomControls;
using MHG.Sample.Dependency.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;
using DatePicker = Xamarin.Forms.DatePicker;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace MHG.Sample.Dependency.Droid.CustomRenderer
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (Element != null)
            {
                //Portable projemizdeki arayüzde kullandýðýmýz elemente ulaþýyoruz Element property'isi ile.
                var element = (CustomDatePicker) Element;
                //C# Color Sýnýfýný ToAndroid extension'u sayesinde java sýnýfýna uygun modele getiriyor.
                Control.SetTextColor(element.TextColor.ToAndroid());
            }
        }
    }
}