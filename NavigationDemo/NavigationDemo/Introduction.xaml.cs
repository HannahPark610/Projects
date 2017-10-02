using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NavigationDemo
{
    public partial class Introduction : ContentPage
    {
        public Introduction()
        {
            InitializeComponent();
            myListView.ItemsSource = new List<Group>
            {
                new Group("M1","M")
                {
                    new ContactData{Name="Mitali", Status="Active"},
                    new ContactData{Name="Mary", Status="Sleeping"},
                    new ContactData{Name="Mosh", Status="Active"}
            }

            };

        }
    }
}
