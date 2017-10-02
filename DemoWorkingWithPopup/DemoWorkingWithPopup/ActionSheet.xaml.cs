using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWorkingWithPopup
{
    public partial class ActionSheet : ContentPage
    {
        public ActionSheet()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object  sender, EventArgs e)
        {
            var respone = await DisplayActionSheet("Contact Methods", "Cancle", "Delete", "Call", "Message", "Email", "WhatsApp", "Facebook");
            await DisplayAlert("Your ContactMethod", respone, "OK");
        }

    }
}
