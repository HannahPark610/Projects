using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExerciseNavigationDemo
{
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();
			listView.ItemsSource = new List<ModelClass>
			{
				new ModelClass{UserId= 1, Description="Active", ImageUrl="http://lorempixel.com/100/100/people/{UserId}"},

			};
		}
		private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var Contact1 = e.SelectedItem as ModelClass;
			Navigation.PushAsync(new Details(Contact1));
        }
    }
}
