using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NavigationDemo
{
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }
		private async void Button_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Introduction());
		}
    }
}
