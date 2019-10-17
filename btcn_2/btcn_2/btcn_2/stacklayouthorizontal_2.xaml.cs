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
    public partial class stacklayouthorizontal_2 : ContentPage
    {
        public stacklayouthorizontal_2()
        {
            InitializeComponent();
        }
        private void Button_clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("chao", "stackhorizontal", "thoat");
        }
    }
}