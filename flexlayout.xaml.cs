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
	public partial class flexlayout : ContentPage
	{
		public flexlayout ()
		{
			InitializeComponent ();
		}
        private void Button_clicked_4(object sender, EventArgs e)
        {
            DisplayAlert("chao", "flexlayout", "thoat");
        }
    }
}