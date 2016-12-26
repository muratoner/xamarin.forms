using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHG.Sample.Localizer.Resx;
using Xamarin.Forms;

namespace MHG.Sample.Localizer.Views
{
    public class LocalizePage : ContentPage
    {
        public LocalizePage()
        {
            Button btnSave = new Button
            {
                Text = Lang.ButtonSave
            };
            btnSave.Clicked += BtnSave_Clicked;

            var tView = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection(Lang.TitleStudentRegister)
                    {
                        new EntryCell
                        {
                            Label = Lang.LabelName,
                            Keyboard = Keyboard.Text
                        },
                        new EntryCell
                        {
                            Label = Lang.LabelSurname,
                            Keyboard = Keyboard.Plain
                        },
                        new EntryCell
                        {
                            Label = Lang.LabelPassword,
                            Keyboard = Keyboard.Numeric
                        }
                    }
                }
            };

            Content = tView;
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            DisplayAlert(Lang.MessageSuccessTitle, Lang.MessageSuccessMessage, Lang.ButtonOk);
        }
    }
}
