using System;
using System.Collections.Generic;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.OneSignal;

namespace MHG.Sample.PushNotification.OneSignal.Droid
{
    [Activity(Label = "MHG.Sample.PushNotification.OneSignal", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Com.OneSignal.OneSignal.NotificationReceived exampleNotificationReceivedDelegate = delegate (OSNotification notification)
            {
                try
                {
                    System.Console.WriteLine("OneSignal Notification Received:\nMessage: {0}", notification.payload.body);
                    Dictionary<string, object> additionalData = notification.payload.additionalData;

                    if (additionalData.Count > 0)
                        System.Console.WriteLine("additionalData: {0}", additionalData);
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                }
            };

            // Notification Opened Delegate
            Com.OneSignal.OneSignal.NotificationOpened exampleNotificationOpenedDelegate = delegate (OSNotificationOpenedResult result)
            {
                try
                {
                    System.Console.WriteLine("OneSignal Notification opened:\nMessage: {0}", result.notification.payload.body);
                    Dictionary<string, object> additionalData = result.notification.payload.additionalData;
                    if (additionalData.Count > 0)
                        System.Console.WriteLine("additionalData: {0}", additionalData);


                    List<Dictionary<string, object>> actionButtons = result.notification.payload.actionButtons;
                    if (actionButtons.Count > 0)
                        Console.WriteLine("actionButtons: {0}", actionButtons);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            };

            // Initialize OneSignal
            Com.OneSignal.OneSignal.StartInit("588e8af1-b8df-4490-9b95-20fc7d2a0f03", "799588154489")
              .HandleNotificationReceived(exampleNotificationReceivedDelegate)
              .HandleNotificationOpened(exampleNotificationOpenedDelegate)
              .EndInit();


            //Bu cihazı etikeklemeye yarıyor hangi departmanda ise ve id'si ne ise belirtebiliyoruz ayrıca birden fazla tag'de tanımlanabiliyor.
            Com.OneSignal.OneSignal.SendTag("software", "1");

            Com.OneSignal.OneSignal.IdsAvailable(new Com.OneSignal.OneSignal.IdsAvailableCallback((id, token) =>
            {

            }));

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

