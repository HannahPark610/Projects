using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Day1_Essential
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
			Content = new Label
			{
				Text = "Hello World",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center

			};
        }
    }
}
