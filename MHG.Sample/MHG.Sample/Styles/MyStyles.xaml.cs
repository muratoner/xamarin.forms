using System;

using Xamarin.Forms;

namespace MHG.Sample.Styles
{
    public partial class MyStyles : ContentPage
    {
        public MyStyles()
        {
            InitializeComponent();
        }

        int i;
        private void Button_OnClicked(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                Application.Current.Resources["DefaultTitle"] = Application.Current.Resources["NewTitle"];
                Application.Current.Resources["DefaultButton"] = Application.Current.Resources["NewButton"];
                Application.Current.Resources["DefaultBackground"] = Application.Current.Resources["NewBackground"];
                Application.Current.Resources["DefaultContent"] = Application.Current.Resources["NewContent"];
            }
            else
            {
                Application.Current.Resources["NewTitle"] = Application.Current.Resources["DefaultTitle"];
                Application.Current.Resources["NewButton"] = Application.Current.Resources["DefaultButton"];
                Application.Current.Resources["NewBackground"] = Application.Current.Resources["DefaultBackground"];
                Application.Current.Resources["NewContent"] = Application.Current.Resources["DefaultContent"];
            }
            i++;
        }
    }
}
