using System;
using MHG.Sample.Social.Model;
using MHG.Sample.Social.Provider;
using Xamarin.Forms;

namespace MHG.Sample.Social.Views
{
    public class FacebookPage : ContentPage
    {
        public string Url =>
                "https://www.facebook.com/dialog/oauth?" +
                "client_id=211845542607268&" +
                "display=popup&" +
                "response_type=token&"+
                "redirect_uri=http://www.facebook.com/connect/login_success.html";

        public FacebookPage()
        {
            BackgroundColor = Color.White;
            var web = new WebView
            {
                Source = Url
            };

            web.Navigated += Web_Navigated;

            Content = web;
        }

        private async void Web_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Result == WebNavigationResult.Success)
            {
                var access_token = ExtractAccessTokenFromUrl(e.Url);
                if (!string.IsNullOrEmpty(access_token))
                {
                    var manager = await new ServiceManager<Profile>().GetFacebookProfile(access_token);
                    SetFacebookProfile(manager);
                }
            }
        }

        private void SetFacebookProfile(Profile profile)
        {
            Image profilePicture = new Image
            {
                Source = ImageSource.FromUri(new Uri($"https://graph.facebook.com/{profile.Id}/picture?width=500")),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 500
            };

            Label lblName = new Label
            {
                Text = profile.Name,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                FontSize = 25
            };

            var stack = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                //İç boşluk
                Padding = 10,
                //Nesnelerin birbirine olan uzaklığı
                Spacing = 10
            };
            stack.Children.Add(profilePicture);
            stack.Children.Add(lblName);

            Content = stack;
        }

        string ExtractAccessTokenFromUrl(string uri)
        {
            if (uri.Contains("access_token") && uri.Contains("&expires_in="))
            {
                var http = "https";
                if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.WinPhone)
                    http = "http";
                var accesstoken = uri.Replace(http + "://www.facebook.com/connect/login_success.html#access_token=", "");
                accesstoken = accesstoken.Remove(accesstoken.IndexOf("&expires_in="));
                return accesstoken;
            }
            return "";
        }
    }
}
