using System;
using System.Collections.Generic;
using System.Linq;
using MHG.Sample.Model;
using Xamarin.Forms;

namespace MHG.Sample.Templates
{
    public partial class ListViewSampleWithLocalImage : ContentPage
    {
        public ListViewSampleWithLocalImage()
        {
            InitializeComponent();

            //1.Kullanım
            LstPeople.ItemsSource = PersonFactory.BindingWithGrouping();

            SearchBar.TextColor = Device.OnPlatform(Color.Black, Color.White, Color.Default);

            LstPeople.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async (t) =>
                {
                    await LstPeople.ScaleTo(0.95, 100, Easing.BounceOut);
                    await LstPeople.ScaleTo(1, 100, Easing.SinIn);
                    await LstPeople.RotateTo(360, 1500, Easing.BounceOut);
                })
            });

            //2.Kullanım
            //Bu seçeneği kullanınca lwPeople nesnesine ItemsSource="{Binding .}" tanımını yapmak gerekiyor
            //LstPeople.BindingContext = new PersonFactory();

            //3.Kullanım
            //Page'in genel BindingContext'ine set edip lwPeople nesnesine ItemsSource="{Binding .}" tanımı yapmak yetecektir.
            //BindingContext =
        }

        private void LstPeople_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            var listview = (sender as ListView);
            var data = (listview.SelectedItem as Person);
            DisplayAlert(data.Fullname, data.Description, "OK");

            //Seçili olan listview item'inin arkaplanı renkleniyor bu rengi yok etmek için böyle bir hack uyguluyoruz.
            listview.SelectedItem = null;
        }

        private void LstPeople_OnRefreshing(object sender, EventArgs e)
        {
            var data = PersonFactory.BindingWithGrouping();
            LstPeople.BindingContext = data;
            LstPeople.IsRefreshing = false;
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e != null)
            {
                var data = PersonFactory.BindingWithGrouping(e.NewTextValue);
                LstPeople.BindingContext = data;
            }
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            var menuitem = Convert.ToInt32((sender as MenuItem).CommandParameter);
            var selecteditem = PersonFactory.People.FirstOrDefault(t => t.ID == menuitem);
            DisplayAlert("Güncelleme", $"{selecteditem.Fullname} adlı kişiyi silmek istediğinize eminmisiniz?", "Tamam",
                "İptal");
        }
    }
}
