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
            listView.ItemsSource = new List<ContactData>
            {
                new ContactData{Name="Hannah", Status="Active"},
                new ContactData{Name="Mitali", Status="Active"},
                new ContactData{Name="Saeko", Status="Active"},
                new ContactData{Name="Shinji", Status="Active"},
                new ContactData{Name="Ai", Status="Active"},
                new ContactData{Name="Sena", Status="Active"}
            };
        }
        // Handler evet That handles the selection in listView
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Contact1 = e.SelectedItem as ContactData;
            Navigation.PushAsync(new Details(Contact1));
        }
    }
}
