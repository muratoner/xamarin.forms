using Xamarin.Forms;

namespace MHG.Sample.CarouselView
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new CarouselPage());
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
