using MHG.Sample.Dependency.CustomControls;
using MHG.Sample.Dependency.iOS.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace MHG.Sample.Dependency.iOS.CustomRenderer
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            var element = (CustomDatePicker) Element;
            if (element != null)
                Control.TextColor = element.TextColor.ToUIColor();
        }
    }
}