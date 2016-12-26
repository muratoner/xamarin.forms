using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MHG.Sample.Templates
{
    public partial class RotationText : ContentPage
    {
        public RotationText()
        {
            InitializeComponent();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            rotateLabel.Rotation = e.NewValue;
            displayLabel.Text = $"Rotation: {e.NewValue} desgrees.";
        }
    }
}
