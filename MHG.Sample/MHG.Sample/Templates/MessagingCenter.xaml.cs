using System;
using Xamarin.Forms;

namespace MHG.Sample.Templates
{
    public partial class MessagingCenter : ContentPage
    {
        public MessagingCenter()
        {
            InitializeComponent();
        }

        private void BtnSend_OnClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.MessagingCenter.Send(this, "Message", TxtText.Text);
        }

        private void BtnSubscribe_OnClicked(object sender, EventArgs e)
        {
            //Parametre olmadan bu şekilde tanımlama yapılabiliyor.
            //Xamarin.Forms.MessagingCenter.Subscribe<MessagingCenter>(this, "Message", (T) =>
            //{
            //    DisplayAlert("Tetiklendim", "Biri beni tetikledi :)", "OK");
            //});

            //Buda parametreli tanımlama oluyor.
            Xamarin.Forms.MessagingCenter.Subscribe<MessagingCenter, string>(this, "Message", (send, arg) =>
            {
                DisplayAlert("Tetiklendim", $"Biri beni tetikledi :) ve Bunu söyledi: {arg}", "OK");
            });
        }

        private void BtnUnSubscribe_OnClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.MessagingCenter.Unsubscribe<MessagingCenter>(this, "Message");
        }
    }
}
