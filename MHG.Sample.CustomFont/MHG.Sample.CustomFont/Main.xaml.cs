using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MHG.Sample.CustomFont {
    public partial class Main : ContentPage {
        public Main() {
            InitializeComponent();

            BindingContext = new {
                Model = new {
                    Text1 = "Lato Regular",
                    Text2 = "Lato Bold",
                    Text3 = "Roboto Regular",
                    Text4 = "Roboto Bold"
                }
            };
        }
    }
}
