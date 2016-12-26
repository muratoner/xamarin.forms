using System;
using System.Globalization;
using System.Threading;
using Foundation;
using MHG.Sample.Localizer.iOS.LocalizeDependency;
using MHG.Sample.Localizer.Localization;
using Xamarin.Forms;

[assembly: Dependency(typeof(Localize))]
namespace MHG.Sample.Localizer.iOS.LocalizeDependency
{
    public class Localize : ILocalize
    {
        public void SetLocale()
        {
            var iosLocaleAuto = NSLocale.CurrentLocale.LocaleIdentifier;
            var netLocale = iosLocaleAuto.Replace("_", "-");
            CultureInfo ci;
            try
            {
                ci = new CultureInfo(netLocale);
            }
            catch (Exception)
            {
                ci = GetCurrentCultureInfo();
            }
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        public CultureInfo GetCurrentCultureInfo()
        {
            var pref = "en-US";

            try
            {
                return new CultureInfo(NSLocale.CurrentLocale.LocaleIdentifier.Replace("_","-"));
            }
            catch (Exception ex)
            {
                return new CultureInfo(pref);
            }
        }
    }
}