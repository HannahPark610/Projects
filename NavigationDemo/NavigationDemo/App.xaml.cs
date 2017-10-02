using Xamarin.Forms;

namespace NavigationDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

//          MainPage = new NavigationPage(new NavigationDemo.Contact()); 
            //    .Contact : Starting Page

            MainPage = new TabbedPageDemo();

		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
