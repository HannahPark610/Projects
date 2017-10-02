using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWorkingWithPopup
{
    public partial class Picker : ContentPage
    {

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedMethod = mypicker.Items[mypicker.SelectedIndex];
			DisplayAlert("Selection", selectedMethod, "OK");
        }

        public Picker()
        {
            InitializeComponent();
        }

    }
}
