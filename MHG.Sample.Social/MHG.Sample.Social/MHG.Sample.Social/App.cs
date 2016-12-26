using MHG.Sample.Social.Views;
using Xamarin.Forms;

namespace MHG.Sample.Social
{
    public class App : Application
    {
        public App()
        {
            //MainPage = new NavigationPage(new FacebookPage());
            MainPage = new TwitterPage();
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
