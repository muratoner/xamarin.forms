using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MHG.Sample.Localizer.Localization
{
    [ContentProperty("Text")]
    class Translate : IMarkupExtension
    {

        readonly CultureInfo ci = null;
        public string Text { get; set; }
        const string ResourceId = "MHG.Sample.Localizer.Resx.Lang";

        public Translate()
        {
            if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android)
            {
                ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return "";

            ResourceManager temp = new ResourceManager(ResourceId, typeof(Translate).GetTypeInfo().Assembly);
            return temp.GetString(Text, ci);
        }
    }
}
