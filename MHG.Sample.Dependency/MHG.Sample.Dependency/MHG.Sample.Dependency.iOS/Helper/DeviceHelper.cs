using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MHG.Sample.Dependency.Helper;
using MHG.Sample.Dependency.iOS.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace MHG.Sample.Dependency.iOS.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ben iOS";
        }
    }
}