using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MHG.Sample.Dependency.CustomControls;
using MHG.Sample.Dependency.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MHG.Sample.Dependency.iOS.CustomRenderer
{
    public class CustomEntryRenderer : Xamarin.Forms.Platform.iOS.EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.TextColor = UIColor.Blue;
            Control.TextColor = UIColor.Cyan;
        }
    }
}