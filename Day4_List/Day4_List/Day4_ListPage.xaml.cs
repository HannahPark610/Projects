using Xamarin.Forms;

namespace Day4_List
{
    public partial class Day4_ListPage : ContentPage
    {
        public Day4_ListPage()
        {
            InitializeComponent();
			// simple listview
			//var names = new List<string>
			//{
			//    "Mitali",
			//    "Ai",
			//    "Saeko",
			//    "Sena",
			//    "Shinji",
			//    "Hanna"
			//};
			//myListView.ItemsSource = names;
			myListView.ItemsSource = new List<ContactData>
			{
				new ContactData {Name="Mitali",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/1"},
				new ContactData {Name="Ai",Status="Absent",ImageUrl="http://lorempixel.com/100/100/people/2"},
				new ContactData {Name="Saeko",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/3"},
				new ContactData {Name="Sena",Status="Present",ImageUrl="http://lorempixel.com/100/100/people/1"}

			};
        }
    }
}
