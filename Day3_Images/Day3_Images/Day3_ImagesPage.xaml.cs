using Xamarin.Forms;

namespace Day3_Images
{
    public partial class Day3_ImagesPage : ContentPage
    {
        public Day3_ImagesPage()
        {
            InitializeComponent();
			var ImageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
			i1.Source = ImageSource;
			ImageSource.CachingEnabled = true;
        }
    }
}
