using MHG.TRCommerce.Views;
using Xamarin.Forms;

namespace MHG.TRCommerce {
    public class App : Application {
        public App()
        {
            var start = new Start
            {
                Master = new Menu(),
                Detail = new Carousel()
            };
            MainPage = start;
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
