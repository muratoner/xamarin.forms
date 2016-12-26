using System.Threading.Tasks;
using Xamarin.Forms;

namespace MHG.Sample.Toolkit
{
    public class RotateAction : TriggerAction<VisualElement>
    {
        public RotateAction()
        {
            // Set Defaults
            Anchor = new Point(0.5, .5);
            Easing = Easing.Linear;
            Length = 250;
            Rotation = 0;
        }

        public int Delay { get; set; }
        public Point Anchor { get; set; }
        public double Rotation { get; set; }
        public int Length { get; set; }
        [TypeConverter(typeof(EasingConverter))]
        public Easing Easing { get; set; }
        protected override async void Invoke(VisualElement sender)
        {
            sender.AnchorX = Anchor.X;
            sender.AnchorY = Anchor.Y;
            await Task.Delay(Delay);
            await sender.RotateTo(Rotation, (uint)Length, Easing);
        }
    }
}
