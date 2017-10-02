using System;
using System.Collections.Generic;
namespace NavigationDemo
{
    public class Group : List<ContactData>
    {
        public string Title 
        { 
            get; set; 
        }
		public string ShortTitle 
        { 
            get; set; 
        }
		public Group(string title, string shorttitle)
		{
			this.Title = title;
			this.ShortTitle = shorttitle;
        }
    }
}
