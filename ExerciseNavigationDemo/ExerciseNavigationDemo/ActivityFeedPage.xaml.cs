using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExerciseNavigationDemo
{
    public partial class ActivityFeedPage : ContentPage
    {
        public ActivityFeedPage()
        {
			InitializeComponent();
			var ImageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/100/100/people/{UserId}") };
			i1.Source = ImageSource;
            ImageSource.CachingEnabled = true;

		}
		private void Button_Clicked(object sender, EventArgs e)
		{
            Navigation.PushModalAsync(new UserProfilePage());
		}
    }
}
