using System;
using Xamarin.Forms;

namespace MHG.Sample.GestureRecognizer
{
    public partial class PinchGesturePage : ContentPage
    {
        public PinchGesturePage()
        {
            InitializeComponent();

            Content = new Grid
            {
                Children =
                {
                    new PinchToZoomContainer
                    {
                        Content = new Image
                        {
                            Source = ImageSource.FromFile("Default.png")
                        }
                    }
                }
            };
        }
    }
}
