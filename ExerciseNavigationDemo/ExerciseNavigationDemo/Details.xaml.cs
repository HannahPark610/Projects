using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExerciseNavigationDemo
{
    public partial class Details : ContentPage
    {
        public Details(ModelClass Contacts)
        {
            if (Contacts == null)
				throw new ArgumentNullException();

            BindingContext = Contacts;
			InitializeComponent();
        }
    }
}
