using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHG.Sample.Styles;
using MHG.Sample.Templates;
using Xamarin.Forms;

namespace MHG.Sample
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new Master
            {
                Icon = "menu.svg"
            };

            Detail = new EntryAnimationWithTrigger();
        }
    }
}
