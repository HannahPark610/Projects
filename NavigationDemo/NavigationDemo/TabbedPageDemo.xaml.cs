using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationDemo
{
    public partial class TabbedPageDemo : TabbedPage
    {
        public TabbedPageDemo()
        {
			InitializeComponent();
            var Page1 = new NavigationPage(new Contact());
			Page1.Title = "Activities";
			this.Children.Add(Page1);
            var Page2 = new NavigationPage(new Details());
			Page2.Title = "Profile";
			this.Children.Add(Page2);

		}
	}
}