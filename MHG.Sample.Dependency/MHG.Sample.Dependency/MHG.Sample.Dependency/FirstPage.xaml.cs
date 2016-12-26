using System;
using MHG.Sample.Dependency.Helper;
using MHG.Sample.Dependency.Model;
using Xamarin.Forms;

namespace MHG.Sample.Dependency
{
    public partial class FirstPage : ContentPage
    {
        //Ekran genişlik ve yüksekliğini her rotate'de yakalamak için bu metod kullanılabilir
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width > 1920 && height > 1080)
            {
                //v.b bu şekilde kontroller ile işlemler yapılabilir.
            }
        }

        public FirstPage(string devicename)
        {
            InitializeComponent();

            using (var sql = new SQLiteManager<Student>())
                LwStudents.ItemsSource = sql.GetAll();
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage(), true);
        }

        private void LwStudents_OnRefreshing(object sender, EventArgs e)
        {
            using (var db = new SQLiteManager<Student>())
                LwStudents.ItemsSource = db.GetAllOrderedDesc(T => T.RegisterDate);
            LwStudents.IsRefreshing = false;
        }

        private async void MenuDelete_OnClicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("Silme Onay", "Silmek istediğinize eminmisiniz?", "OK", "CANCEL");
            if (isOk)
            {
                var id = Convert.ToInt32((sender as MenuItem).CommandParameter.ToString());
                using (var db = new SQLiteManager<Student>())
                {
                    var res = db.Delete(id);
                    if (res > 0)
                        LwStudents.ItemsSource = db.GetAllOrderedDesc(T => T.RegisterDate);
                }
            }
        }

        private void MenuDetail_OnClicked(object sender, EventArgs e)
        {
            var id = Convert.ToInt32((sender as MenuItem).CommandParameter.ToString());
            using (var db = new SQLiteManager<Student>())
                Navigation.PushModalAsync(new Detail(db.Get(id)), true);
        }
    }
}
