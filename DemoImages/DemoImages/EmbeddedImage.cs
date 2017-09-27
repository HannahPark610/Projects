using System;

using Xamarin.Forms;

namespace DemoImages
{
    public class EmbeddedImage : ContentPage
    {
        public EmbeddedImage()
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

