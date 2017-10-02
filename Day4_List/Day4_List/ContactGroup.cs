using System;
namespace Day4_List
{
	public class ContactGroup : List<ContactData>
	{
		public string Title { get; set; }
		public string ShortTitle { get; set; }

		public ContactGroup(string title, string shorttitle)
		{
			Title = title;
			ShortTitle = shorttitle;
		}
	}
}
