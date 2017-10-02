using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Day3_Images.EmbeddedImage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            embeddedImage.Source = ImageSource.FromResource("ImageDemo.beach.jpg");
        }
    }
}
