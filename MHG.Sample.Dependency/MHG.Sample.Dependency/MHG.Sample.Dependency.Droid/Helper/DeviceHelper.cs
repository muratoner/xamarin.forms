using MHG.Sample.Dependency.Helper;

[assembly:Xamarin.Forms.Dependency(typeof(MHG.Sample.Dependency.Droid.Helper.DeviceHelper))]
namespace MHG.Sample.Dependency.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ben Droid'im";
        }
    }
}