using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        public HelloWorldPage()
        {
            InitializeComponent();
            slider1.Value = 0.5;
            if(Device.RuntimePlatform.Equals("iOS"))
            {
                Padding = new Thickness(0, 20, 0, 0); // Top, Left, Bottum, Right
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