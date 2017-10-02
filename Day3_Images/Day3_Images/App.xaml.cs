using Xamarin.Forms;

namespace Day3_Images
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Day3_Images.EmbeddedImage();
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
