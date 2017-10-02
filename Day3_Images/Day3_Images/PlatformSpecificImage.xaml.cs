using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Day3_Images
{
    public partial class PlatformSpecificImage : ContentPage
    {
        public PlatformSpecificImage()
        {
            InitializeComponent();
			//btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
			//iOS: "clock.png",
			//Android: "clock.png",
			//WinPhone: "assets/clock.png"
			//));
		}
    }
}
