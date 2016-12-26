using MHG.Sample.Dependency.Helper;
using Xamarin.Forms;

namespace MHG.Sample.Dependency
{
    public class App : Application
    {
        public static string DbName => "sample.db3";

        public App()
        {
            var devicename = DependencyService.Get<IDeviceHelper>().GetDeviceName();

            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        Children =
            //        {
            //            new Label
            //            {
            //                Text = devicename
            //            },
            //            new CustomDatePicker
            //            {
            //                //Bu property'iyi custom oluşturduk
            //                TextColor = Color.Fuchsia,
            //                //Bu propert'i sistemde hazırda mevcut
            //                BackgroundColor = Device.OnPlatform(Color.Aqua, Color.Black, Color.Blue)
            //            }
            //        }
            //    }
            //};

            MainPage = new NavigationPage(new FirstPage(devicename));
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
