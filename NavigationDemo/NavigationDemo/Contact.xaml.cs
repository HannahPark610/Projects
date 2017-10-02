using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo
{
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
            myListView.ItemsSource = new List<ContactData>
            {
                new ContactData{Name="Mitali",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/1"},
                new ContactData{Name="Hannah", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/2"},
                new ContactData{Name="Saeko", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/3"},
                new ContactData{Name="Shinji", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/4"},
                new ContactData{Name="Ai", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/5"},
                new ContactData{Name="Sena", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/6"}
            };
        }
		private async void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var Contact1 = e.SelectedItem as ContactData;
			await Navigation.PushAsync(new Details(Contact1));
		}
    }
}
