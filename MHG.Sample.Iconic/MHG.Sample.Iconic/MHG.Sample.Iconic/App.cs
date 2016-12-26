using Xamarin.Forms;

namespace MHG.Sample.Iconic
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "MHG.Sample.Iconic",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new FormsPlugin.Iconize.IconLabel
                        {
                            HorizontalOptions = LayoutOptions.Center,
                            Text = "fa-500px",
                            FontSize = 50
                        }
                    }
                }
            };

            MainPage = new NavigationPage(new Icon());
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
