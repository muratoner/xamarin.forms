using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using LinqToTwitter;
using Xamarin.Forms;

namespace MHG.Sample.Social.Views
{
    public partial class TwitterPage : ContentPage
    {


        public TwitterPage()
        {
            InitializeComponent();

            BindingContext = GetHasshTagData("#Beşiktaş");
        }

        IAuthorizer GetSingleUser()
        {
            return new SingleUserAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = "C2VawDGo1d0roBY5oo8wRWMoR",
                    ConsumerSecret = "rBlyLI90hSD6fUFG1a9rcDQUMhmokLqin9D4UeUdKccJGu1tt8",
                    OAuthToken = "87167568-NncAN03hBgoDv89CGHb39OltuuvziyW5bQa2jkyaz",
                    OAuthTokenSecret = "5mqm6mhfYck3e2sUNAGx9xpDwhWWB3TYwH63FcTjA0thi"
                }
            };
        }

        public List<Tweets> GetHasshTagData(string hashtag)
        {
            UserDialogs.Instance.ShowLoading("Getting hashtags please wait...", MaskType.Black);

            var res = new List<Tweets>();
            var twitterContext = new TwitterContext(GetSingleUser());

            var hasgtags =
                (from u in twitterContext.Search where u.Type == SearchType.Search && u.Query == "#" + hashtag select u);

            foreach (var tag in hasgtags)
            {
                res.AddRange(tag.Statuses.Select(statu => new Tweets
                {
                    Name = statu.User.Name,
                    Text = statu.Text,
                    Time = statu.CreatedAt,
                    ProfilePicture = statu.User.ProfileBackgroundImageUrl
                }));
            }

            UserDialogs.Instance.HideLoading();
            return res;
        }

        public async Task<List<Tweets>> GetUserTweets(string username)
        {
            UserDialogs.Instance.ShowLoading($"Getting {username} user status. Please wait...", MaskType.Gradient);
            var twitterContext = new TwitterContext(GetSingleUser());

            //ScreenName kullanıdı adı oluyor.
            var res = await (from tweet in twitterContext.Status
                where tweet.Type == StatusType.User &&
                      tweet.ScreenName == username
                select tweet).Select(T => new Tweets { Text = T.Text, Name = T.ScreenName, Time = T.CreatedAt, ProfilePicture = T.User.ProfileImageUrl }).ToListAsync();

            UserDialogs.Instance.HideLoading();
            return res;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            BindingContext = GetHasshTagData(TxtHash.Text);
        }

        private async void BtnGetUserTweets_OnClicked(object sender, EventArgs e)
        {
            BindingContext = await GetUserTweets(TxtHash.Text);
        }
    }

    public class Tweets
    {
        public string Name { get; set; }
        public string ProfilePicture { get; internal set; }
        public string Text { get; internal set; }
        public DateTime Time { get; set; }
    }
}
