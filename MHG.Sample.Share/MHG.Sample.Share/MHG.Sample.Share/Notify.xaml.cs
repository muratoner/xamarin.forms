using System;
using System.Threading.Tasks;
using Plugin.LocalNotifications;
using Xamarin.Forms;

namespace MHG.Sample.Share
{
    public partial class Notify : ContentPage
    {
        public Notify()
        {
            InitializeComponent();
        }

        private async void BtnSimpleNotify_OnClicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Test", "Body", 1, DateTime.Now.AddSeconds(5));
            await Task.Delay(5000);
            CrossLocalNotifications.Current.Cancel(1);
        }
    }
}
