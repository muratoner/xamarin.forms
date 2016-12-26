using System.Collections.Generic;
using MHG.TRCommerce.Model;
using Xamarin.Forms;

namespace MHG.TRCommerce.Views {
    public partial class Main : ContentPage
	{
		public Main (IEnumerable<ProductModel> model, string category)
		{
			InitializeComponent ();
		    LblCategoryName.Text = category;
		    LvCategoryItems.ItemsSource = model;
		}
	}
}
