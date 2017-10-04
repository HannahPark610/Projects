using System;
using Xamarin.Forms;

namespace Day1_Essential
{
    public partial class Day1_EssentialPage : ContentPage
    {
        public Day1_EssentialPage()
        {
            InitializeComponent();
			slider1.Value = 0.5;
			if (Device.RuntimePlatform.Equals("iOS"))
			{
				Padding = new Thickness(0, 20, 0, 0);
			}
			else if (Device.RuntimePlatform.Equals("Android"))
			{
				Padding = new Thickness(10, 20, 0, 0);
			}
			else if (Device.RuntimePlatform.Equals("Windows"))
			{
				Padding = new Thickness(10, 20, 30, 0);
			}
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("Title", "Hello to xamarin.forms", "OK");
		}
	}
}
