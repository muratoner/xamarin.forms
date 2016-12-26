using Xamarin.Forms;

namespace MHG.Sample.Dependency.CustomControls
{
    public class CustomDatePicker : DatePicker
    {
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(CustomDatePicker), Color.Aqua);

        public Color TextColor
        {
            get { return (Color) GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
