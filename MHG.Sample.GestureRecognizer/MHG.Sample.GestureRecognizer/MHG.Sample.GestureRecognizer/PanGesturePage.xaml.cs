using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MHG.Sample.GestureRecognizer
{
    public partial class PanGesturePage : ContentPage
    {
        public PanGesturePage()
        {
            InitializeComponent();

            Content = new AbsoluteLayout
            {
                Children =
                {
                    new PanContainer
                    {
                        Content = new Image
                        {
                            Source = ImageSource.FromFile("Default.png"),
                            WidthRequest = 1920,
                            HeightRequest = 1080
                        }
                    }
                }
            };
        }
    }
}
