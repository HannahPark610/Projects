using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class secondPage2 : ContentPage
    {
        public secondPage2()
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

