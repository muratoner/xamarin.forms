using System;
using System.Threading.Tasks;
using MHG.Sample.RestFull.Provider;
using Xamarin.Forms;

namespace MHG.Sample.RestFull
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            Test();
        }

        async void Test()
        {
            var service = new ServiceManager();
            var resget = await service.Get();
            var respost = await service.Post();
            await DisplayAlert("TEST GET", resget, "OK");
            await DisplayAlert("TEST POST", respost, "OK");
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            AcitivityIndicator.IsRunning = true;
            await Task.Delay(3000);
            AcitivityIndicator.IsRunning = false;
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }
    }
}
