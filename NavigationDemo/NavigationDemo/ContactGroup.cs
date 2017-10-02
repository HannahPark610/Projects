using System;
namespace NavigationDemo
{
	public class ContactGroup : List<ContactData>
	{
		public string Title { get; set; }
		public string ShortTitle { get; set; }
		public ContactGroup(string title, string shorttitle)
		{
			this.Title = title;
			this.ShortTitle = shorttitle;

		}
	}
}
