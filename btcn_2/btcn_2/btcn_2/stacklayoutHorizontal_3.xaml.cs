using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace btcn_2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class stacklayoutHorizontal_3 : ContentPage
	{
		public stacklayoutHorizontal_3 ()
		{
			InitializeComponent ();
		}
        private void Button_clicked_3(object sender, EventArgs e)
        {
            DisplayAlert("chao", "stackHorizontal", "thoat");
        }
    }
}