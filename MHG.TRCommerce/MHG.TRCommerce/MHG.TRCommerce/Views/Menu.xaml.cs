using System;
using System.Collections.Generic;
using MHG.TRCommerce.Model;
using Xamarin.Forms;

namespace MHG.TRCommerce.Views {
    public partial class Menu : ContentPage {
        public Menu() {
            InitializeComponent();
            Title = "TR Commerce";
            //Menü ikonunu değiştiriyoruz bu satır ile
            Icon = "menu.png";

            var model = new List<MenuModel>
            {
                new MenuModel
                {
                    Id = 1,
                    CategoryName = "Bilgisayar"
                },
                new MenuModel
                {
                    Id = 2,
                    CategoryName = "Beyaş Eşya"
                },
                new MenuModel
                {
                    Id = 3,
                    CategoryName = "Oyuncak"
                },
                new MenuModel
                {
                    Id = 3,
                    CategoryName = "Spor"
                },
                new MenuModel
                {
                    Id = 3,
                    CategoryName = "Elektronik"
                }
            };

            LwMenu.ItemsSource = model;
            LwMenu.ItemSelected += delegate(object sender, SelectedItemChangedEventArgs args)
            {
                MenuModel selected = args.SelectedItem as MenuModel;
                DisplayAlert("Menu Item Tıklandı", selected.CategoryName, "OK");
            };
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Button btnKayitOl = sender as Button;
            
        }
    }
}
