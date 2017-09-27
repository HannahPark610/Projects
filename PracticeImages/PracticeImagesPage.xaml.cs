using Xamarin.Forms;

namespace PracticeImages
{
    public partial class PracticeImagesPage : ContentPage
    {
        public PracticeImagesPage()
        {
			InitializeComponent();
			var ImageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/city/1/") };
			p1.Source = ImageSource;
			ImageSource.CachingEnabled = true;
        }
    }
}
