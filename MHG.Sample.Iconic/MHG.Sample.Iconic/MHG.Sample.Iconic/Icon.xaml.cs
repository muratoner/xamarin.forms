using Xamarin.Forms;

namespace MHG.Sample.Iconic
{
    public class Person
    {
        public string Name { get; set; }

        public string Icon { get; set; }
    }

    public partial class Icon : ContentPage
    {
        public Icon()
        {
            InitializeComponent();

            var datas = new Person[]
            {
                new Person
                {
                    Name = "Murat",
                    Icon = "fa-save"
                },
                new Person
                {
                    Name = "Sakine",
                    Icon = "fa-facebook"
                }
            };

            LwIcons.ItemsSource = datas;
        }
    }
}
