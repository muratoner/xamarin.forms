using System;
using System.Collections.Generic;
using MHG.Sample.Model;
using Xamarin.Forms;

namespace MHG.Sample.Templates
{
    public partial class ListViewSample : ContentPage
    {
        public static List<Person> Persons; 

        public ListViewSample()
        {
            InitializeComponent();

            Persons = new List<Person>();

            for (var i = 0; i < new Random().Next(10, 100); i++)
                Persons.Add(new Person(i, Faker.Name.First(), Faker.Name.Last(), Faker.Avatar.Image()));

            //1.Kullanım
            //lwPeople.ItemsSource = people;

            //2.Kullanım
            //Bu seçeneği kullanınca lwPeople nesnesine ItemsSource="{Binding .}" tanımını yapmak gerekiyor
            //lwPeople.BindingContext = people;

            //3.Kullanım
            //Page'in genel BindingContext'ine set edip lwPeople nesnesine ItemsSource="{Binding .}" tanımı yapmak yetecektir.
        }

        private void LwPeople_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null) return;
            var person = (e.SelectedItem as Person);
            DisplayAlert("Seçilen Item", $"{person.Name} {person.Surname}", "OK");
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            DisplayAlert("Tıklanan Button ID'si", btn.CommandParameter.ToString(), "OK");
        }
    }
}
