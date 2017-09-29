using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationDemo
{

	public partial class Details : ContentPage
    {
        public Details(ContactData contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            BindingContext = contact;
            InitializeComponent();

        }
    }
}
