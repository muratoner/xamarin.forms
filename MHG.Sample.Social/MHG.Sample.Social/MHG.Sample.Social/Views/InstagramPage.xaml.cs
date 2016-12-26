using System.Collections.Generic;
using System.Collections.ObjectModel;
using MHG.Sample.Social.Provider;
using Xamarin.Forms;
using MHG.Sample.Social.Model;

namespace MHG.Sample.Social.Views
{
    public partial class InstagramPage : ContentPage
    {
        readonly IList<Item> model = new ObservableCollection<Item>();

        public InstagramPage()
        {
            InitializeComponent();
            GetProfile();
            BindingContext = model;
        }

        async void GetProfile()
        {
            var manager = new ServiceManager<Model.Instagram>();
            var res = await manager.Get("https://www.instagram.com/microsoft/media/");
            foreach (var item in res.Items)
                model.Add(item);
        }
    }
}
