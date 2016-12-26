using Android.App;
using Android.OS;

namespace MHG.Sample.SplashScreen.Droid {
    [Activity( Label = "", NoHistory = true, MainLauncher = true, Theme = "@style/Theme.Splash")]
    public class SplashActivity : Activity {
        protected override void OnCreate( Bundle savedInstanceState ) {
            base.OnCreate( savedInstanceState );

            StartActivity(typeof(MainActivity));
        }
    }
}