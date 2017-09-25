using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class MySecondPage : ContentPage
    {
        public MySecondPage()
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

