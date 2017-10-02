using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWorkingWithPopup
{
    public partial class EntryDemo : ContentPage
    {
        public EntryDemo()
        {
            InitializeComponent();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            myLabel.Text = "COMPLETED";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            myLabel.Text = e.NewTextValue;
        }
    }
}
