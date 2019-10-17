using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace btcn_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void Button_clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new stackHorizonta());
        }
        async private void Button_clicked_1(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new stacklayoutVertical());

        }
        async private void Button_clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new stacklayouthorizontal_2());

        }
        async private void Button_clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new stacklayoutHorizontal_3());


        }
        async private void Button_clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new flexlayout());

        }
        async private void Button_clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new grid());

        }

       
    }
}
