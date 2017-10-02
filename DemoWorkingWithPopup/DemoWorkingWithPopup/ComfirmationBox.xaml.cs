using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWorkingWithPopup
{
    public partial class ComfirmationBox : ContentPage
    {
        public ComfirmationBox()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "OK", "Cancel"); // 'Alert' method need 'async, await'
            if(response)
            {
                await DisplayAlert("Done", "Your Response is Ok", "OK");
            }
            else
            {
				await DisplayAlert("Done", "Your Response is Cancel", "OK");

			}
        }
    }
}
