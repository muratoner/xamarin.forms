using System;
using Android.Graphics;
using MHG.Sample.CustomFont.Droid.CustomControls;
using MHG.Sample.CustomFont.Extesinsons;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(Label), typeof(CustomFontLabelRenderer))]
namespace MHG.Sample.CustomFont.Droid.CustomControls {
    public class CustomFontLabelRenderer : LabelRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement.FontFamily.IsNotNullOrEmpty())
            {
                try
                {
                    var tf = Typeface.CreateFromAsset(Forms.Context.Assets, $"Fonts/{e.NewElement.FontFamily}.ttf");
                    Control.Typeface = tf;
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}