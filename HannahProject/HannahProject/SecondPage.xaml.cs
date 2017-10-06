using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HannahProject
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();

			SecondPageListView.ItemsSource = new List<string>
			{
				"July 12", "July 13", "July 14", "July 21", "July 22",
				"July 23", "July 24", "July 30", "August 1", "August 2",
				"August 3", "August 4", "August 5", "August 6", "August 11",
				"August 12", "August 13", "August 17"
			};

		}
	}
}
