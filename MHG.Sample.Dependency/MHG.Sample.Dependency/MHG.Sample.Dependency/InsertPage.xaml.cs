using System;
using MHG.Sample.Dependency.Helper;
using MHG.Sample.Dependency.Model;
using Xamarin.Forms;

namespace MHG.Sample.Dependency
{
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            using (var db = new SQLiteManager<Student>())
            {
                var res = db.Insert(new Student
                {
                    Name = TxtName.Text,
                    Surname = TxtSurname.Text,
                    RegisterDate = DateTime.Today
                });
                if (res > 0)
                    DisplayAlert("Success", "Insert process successfuly.", "OK");
            }
            
        }
    }
}
