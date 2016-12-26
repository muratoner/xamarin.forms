using MHG.Sample.Templates;
using Xamarin.Forms;

namespace MHG.Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "MHG.Sample",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};

            //MainPage = content;

            // Xaml File Template Use
            //MainPage = new FirstPage();

            // Use Carousel Page
            //MainPage = new MyCarousel();

            // Use Tabbed Page
            //MainPage = new MyTabbed();

            // Use Master Page
            MainPage = new CommandTest();
        }
    }
}