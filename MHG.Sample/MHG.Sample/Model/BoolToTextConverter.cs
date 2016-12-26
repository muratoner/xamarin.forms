using System;
using System.Globalization;
using Xamarin.Forms;

namespace MHG.Sample.Model
{
    class BoolToTextConverter : IValueConverter
    {
        public string TrueText { get; set; }

        public string FalseText { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? TrueText : FalseText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
