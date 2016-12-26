using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHG.Sample.Dependency.Model;
using Xamarin.Forms;

namespace MHG.Sample.Dependency
{
    public partial class Detail : ContentPage
    {
        public Detail(Student student)
        {
            InitializeComponent();

            //Her platformun Large anlayışı farklı olduğundan ilgili platforumun large algılamasını çekiyoruz.
            LblName.FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label));
            LblSurnname.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            LblRegisterDate.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            LblName.Text = student.Name;
            LblSurnname.Text = student.Surname;
            LblRegisterDate.Text = student.RegisterDate.ToString("dd-MM-yyyy hh:mm:ss");
        }
    }
}
