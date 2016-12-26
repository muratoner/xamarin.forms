using System.Globalization;

namespace MHG.Sample.Localizer.Localization
{
    public interface ILocalize
    {
        void SetLocale();
        CultureInfo GetCurrentCultureInfo();
    }
}
