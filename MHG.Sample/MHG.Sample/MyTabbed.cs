using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHG.Sample.Templates;
using Xamarin.Forms;

namespace MHG.Sample
{
    public class MyTabbed : TabbedPage
    {
        public MyTabbed()
        {
            Children.Add(new Page1());
            Children.Add(new Page2());
        }
    }
}
