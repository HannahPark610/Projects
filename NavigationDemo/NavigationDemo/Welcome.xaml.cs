using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationDemo
{
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }
		private async void Button_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Introduction());
		}
    }
}
