﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace btcn_2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class stacklayoutVertical : ContentPage
	{
		public stacklayoutVertical ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("chao", "stackVertical", "thoat");
        }
    }
}