using MHG.Sample.Localizer.Localization;
using MHG.Sample.Localizer.Resx;
using MHG.Sample.Localizer.Views;
using Xamarin.Forms;

namespace MHG.Sample.Localizer
{
    public class App : Application
    {
        public App()
        {
            if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
            {
                var culture = DependencyService.Get<ILocalize>();
                culture.SetLocale();
                Lang.Culture = culture.GetCurrentCultureInfo();
            }

            // The root page of your application
            var content = new ContentPage
            {
                Title = "MHG.Sample.Localizer",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(new LocalizePageTest());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
