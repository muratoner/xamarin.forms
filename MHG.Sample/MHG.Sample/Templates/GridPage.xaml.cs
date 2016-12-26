using System;
using Xamarin.Forms;

namespace MHG.Sample.Templates
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var message = "Bu benim mesajım. lütfen beni yanlış anlama olurmu";
            var res  = await DisplayAlert("Merhaba", message, "Acceptation", "Cancellitation");
            if (res)
                await DisplayAlert("Acceptli", "Acceptition meesage", "Cancel"); 
            else
                await DisplayAlert("Cancel", "Cancel meesage", "Cancelitation");

            var resStr = await DisplayActionSheet("Test Title", "Test Cancel", "Test Destruction", "OK", "Fuck", "Juck");
            switch (resStr)
            {
                case "OK":
                        await DisplayAlert("OK", "OK", "OK");
                    break;
            }

        }
    }
}
