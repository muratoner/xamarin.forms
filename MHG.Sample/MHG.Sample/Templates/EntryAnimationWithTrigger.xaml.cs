using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MHG.Sample.Templates
{
    public partial class EntryAnimationWithTrigger : ContentPage
    {
        public EntryAnimationWithTrigger()
        {
            InitializeComponent();

            FontAwesomeIcon.Text = Sample.Controls.FontAwesomeIcon.Icon.plus_circled;
        }
    }
}
