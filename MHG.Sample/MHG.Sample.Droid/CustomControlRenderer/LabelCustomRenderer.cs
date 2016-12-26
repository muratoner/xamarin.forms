using Android.Graphics;
using MHG.Sample.Controls;
using MHG.Sample.Droid.CustomControlRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(LabelCustomRenderer))]
namespace MHG.Sample.Droid.CustomControlRenderer
{
    public class LabelCustomRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "fonts/font_fontello.ttf");
            }
        }
    }
}