using System;

using Xamarin.Forms;

namespace DemoLayouts
{
    public class GridLayout : ContentPage
    {
        public GridLayout()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

