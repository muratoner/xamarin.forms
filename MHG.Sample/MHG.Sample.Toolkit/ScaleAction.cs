using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MHG.Sample.Toolkit
{
    public class ScaleAction : TriggerAction<VisualElement>
    {
        public ScaleAction()
        {
            Anchor = new Point(0, 0.5);
            Scale = 1;
            Easing = Easing.SpringIn;
            Length = 250;
        }

        public Point Anchor { get; set; }
        public double Scale { get; set; }
        [TypeConverter(typeof(EasingConverter))]
        public Easing Easing { get; set; }
        public int Length { get; set; }

        protected override async void Invoke(VisualElement sender)
        {
            sender.AnchorX = Anchor.X;
            sender.AnchorY = Anchor.Y;
            await sender.ScaleTo(Scale, (uint) Length, Easing);
        }
    }
}
