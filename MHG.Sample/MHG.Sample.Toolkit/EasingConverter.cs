using System;
using System.Globalization;
using System.Reflection;
using Xamarin.Forms;

namespace MHG.Sample.Toolkit
{
    public class EasingConverter : TypeConverter
    {
        public override bool CanConvertFrom(Type sourceType)
        {
            if (sourceType == null)
                throw new ArgumentNullException(nameof(sourceType));

            return (sourceType == typeof(string));
        }

        [Obsolete("use ConvertFromInvariantString (string)")]
        public override object ConvertFrom(CultureInfo culture, object value)
        {
            if (!(value is string))
                return null;

            var name = ((string)value).Trim();

            if (name.StartsWith("Easing"))
                name = name.Substring(7);

            var field = typeof(Easing).GetRuntimeField(name);

            if (field != null && field.IsStatic)
                return (Easing)field.GetValue(null);

            throw new InvalidOperationException(
                $"Cannot convert \"{value}\" into Xamarin.Forms.Easing");
        }
    }
}
