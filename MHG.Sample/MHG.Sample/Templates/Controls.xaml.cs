using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHG.Sample.Model;
using Xamarin.Forms;

namespace MHG.Sample.Templates
{
    public partial class Controls : ContentPage
    {
        public List<Person> Items { get; set; }

        public Controls()
        {
            InitializeComponent();

            Items = new List<Person>();

            for (var i = 0; i < new Random().Next(10, 100); i++)
            {
                Picker.Items.Add($"{Faker.Name.First()} {Faker.Name.Last()}");
            }

            DatePicker.MaximumDate = new DateTime(1989, 12, 23);
            DatePicker.MaximumDate = new DateTime(2016, 12, 12);
            DatePicker.Date = DateTime.Today;
            DatePicker.Format = "dd-MM-yyyy";

            // WebView kullanımı
            //var webview = new WebView
            //{
            //    Source = new UrlWebViewSource
            //    {
            //        Url = "http://muratoner.net"
            //    }
            //};

            //Content = webview;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Bar.ProgressTo(0.9, 1500, Easing.BounceOut);
            Indicator.IsRunning = true;
        }

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (sender as Picker);
            DisplayAlert("Picker", picker.Items[picker.SelectedIndex], "OK");
        }

        private void Stepperm_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelStep.Text = e.NewValue.ToString("##");
        }
    }
}
