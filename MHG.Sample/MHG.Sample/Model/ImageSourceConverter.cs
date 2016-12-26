using System;
using System.Globalization;
using Xamarin.Forms;

namespace MHG.Sample.Model
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource($"MHG.Sample.Images.{value ?? ""}");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}