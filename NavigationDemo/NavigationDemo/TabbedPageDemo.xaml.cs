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
			this.Children.Add(new Welcome());
			this.Children.Add(new Contact());
        }
    }
}
