using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Introduction : ContentPage
    {
        public Introduction()
        {
            InitializeComponent();
        }

		private async void Button_Clicked(object sender, EventArgs e)
		{
            await Navigation.PopModalAsync();
		}
    }
}
