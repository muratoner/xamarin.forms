using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Share;
using Xamarin.Forms;

namespace MHG.Sample.Share
{
    public partial class CameraPlugin : ContentPage
    {
        public CameraPlugin()
        {
            InitializeComponent();
        }

        private async void BtnTakePicture_OnClicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Error", "Kameray meşgul yada fotoğraf çekme desteklenmiyor.", "Tamam");
                return;
            }
            var camera = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                AllowCropping = true,
                CompressionQuality = 50,
                SaveToAlbum = true,
                DefaultCamera = CameraDevice.Front,
                Name = "Test"
            });

            if (camera == null)
                return;

            await DisplayAlert("Title", $"Path: {camera.Path}\nAlbum: {camera.AlbumPath}", "OK");

            ImageResult.Source = ImageSource.FromStream(() => camera.GetStream());
        }

        private async void BtnPickPhoto_OnClicked(object sender, EventArgs e)
        {
            var result = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                CompressionQuality = 50
            });

            if(result == null)
                return;

            ImageResult.Source = ImageSource.FromStream(() => result.GetStream());
        }

        private async void BtnTakeVideo_OnClicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakeVideoSupported)
            {
                await DisplayAlert("Video Take", "Kamera meşgul yada desteklenmiyor", "OK");
                return;
            }

            var video = await CrossMedia.Current.TakeVideoAsync(new StoreVideoOptions
            {
                AllowCropping = true,
                Quality = VideoQuality.Medium
            });
        }


        private async void BtnPickVideo_OnClicked(object sender, EventArgs e)
        {
            var res = await CrossMedia.Current.PickVideoAsync();

            if (res == null)
                return;

            CrossVideoPlayerView.VideoSource = res.Path;
        }
    }
}
