using Xamarin.Forms;
using System;

namespace DemoImages
{
    public partial class DemoImagesPage : ContentPage
    {
        public DemoImagesPage()
        {
			InitializeComponent();
			var ImageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
			i1.Source = ImageSource;
			ImageSource.CachingEnabled = true;

        }
    }
}
