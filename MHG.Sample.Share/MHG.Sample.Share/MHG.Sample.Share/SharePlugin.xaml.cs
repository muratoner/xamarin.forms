using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace MHG.Sample.Share
{
    public partial class SharePlugin : ContentPage
    {
        public SharePlugin()
        {
            InitializeComponent();

        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            //Title ve Description ile paylaş özelliğini kullanabiliyoruz.
            //CrossShare.Current.Share(Description.Text, Title.Text);

            //Url ve title, description paylaşabiliyoruz.
            //CrossShare.Current.ShareLink(Url.Text, Description.Text, Title.Text);

            //InBrowser sayfa açabiliyorum
            CrossShare.Current.OpenBrowser("http://www.muratoner.net", new BrowserOptions
            {
                ChromeShowTitle = true,
                UseSafairReaderMode = true,
                UseSafariWebViewController = true
            });
        }

        private void Copy_OnClicked(object sender, EventArgs e)
        {
            if (CrossShare.Current.SupportsClipboard)
                CrossShare.Current.SetClipboardText(Title.Text, Description.Text);
        }
    }
}
