using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MHG.Sample.GestureRecognizer
{
    public partial class TapGesturePage : ContentPage
    {
        int tapCount = 0;
        Label lblTap;

        public TapGesturePage()
        {
            InitializeComponent();

            BackgroundColor = Color.Black;

            lblTap = new Label
            {
                FontSize = 25,
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(0,10,0,10),
                VerticalOptions = LayoutOptions.Start,
                Text = "0",
                TextColor = Color.White
            };

            var image = new Image
            {
                Source = "Default.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            var tapCount = 0;
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (sender, args) =>
            {
                tapCount++;
                lblTap.Text = tapCount.ToString();

                if (tapCount % 2 == 0)
                {
                    image.ScaleTo(1, 2500, Easing.BounceIn);
                }
                else
                {
                    image.ScaleTo(0.5, 2000, Easing.BounceIn);
                }
            };

            //Kaç defa tıklama ile gesture recognizer'in çalışacağını belirtiyoruz. Default=1
            tapGestureRecognizer.NumberOfTapsRequired = 2;
            image.GestureRecognizers.Add(tapGestureRecognizer);

            Content = new StackLayout
            {
                Children =
                {
                    lblTap,
                    image,
                }
            };
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            
        }
    }
}
