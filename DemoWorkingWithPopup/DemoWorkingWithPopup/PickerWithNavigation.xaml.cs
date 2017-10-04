using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWorkingWithPopup
{
    public partial class PickerWithNavigation : ContentPage
    {
        public PickerWithNavigation()
        {
            InitializeComponent();
        }

			private void ViewCell_Tapped(object sender, EventArgs e)
			{
				var page = new ContactMethodPage();
				page.ContactMethod.ItemSelected += (source, args) =>
				{
					data.Text = args.SelectedItem.ToString();
					Navigation.PopAsync();
				};
				Navigation.PushAsync(page);
        }
    }
}
