using System.Globalization;
using System.Threading;
using MHG.Sample.Localizer.Droid.LocalizeDependency;
using MHG.Sample.Localizer.Localization;

[assembly:Xamarin.Forms.Dependency(typeof(Localize))]
namespace MHG.Sample.Localizer.Droid.LocalizeDependency
{
    public class Localize : ILocalize
    {
        public void SetLocale()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLocale = androidLocale.ToString().Replace("_", "-");
            var ci = new CultureInfo(netLocale);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        public CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLocale = androidLocale.ToString().Replace("_", "-");
            return new CultureInfo(netLocale);
        }
    }
}