using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWorkingWithPopup
{
    class Contact
    {
        public string Name { get; set; }
        public int ID { get; set; }

    }
    public partial class Picker : ContentPage
    {
        private IList<Contact> ContactMethod;
        public Picker()
        {
            InitializeComponent();
            ContactMethod = GetContactMethod();
            foreach (var methods in ContactMethod)
            {
                myPicker.Items.Add(methods.Name);
            }

        }
        private IList<Contact> GetContactMethod()
        {
            return new List<Contact>
            {
                new Contact { ID = 1, Name="Call"},
                new Contact { ID = 2, Name = "Message"},
                new Contact { ID = 3, Name = "Email"},
                new Contact { ID = 4, Name = "WhatsApp"}
            };
        }
        private void myPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Finding the selected object from picker control
            var index = myPicker.Items[myPicker.SelectedIndex];
            DisplayAlert("Selection", index, "OK");
        }
    }
}

   //     void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
   //     {
   //         var selectedMethod = mypicker.Items[mypicker.SelectedIndex];
			//DisplayAlert("Selection", selectedMethod, "OK");
        //}

  