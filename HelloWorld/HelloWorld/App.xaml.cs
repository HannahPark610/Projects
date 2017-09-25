using Xamarin.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HelloWorld.secondPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine("Its in OnStart()");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine("Its in OnSleep()");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("Its in OnResume()");
        }
    }
}
