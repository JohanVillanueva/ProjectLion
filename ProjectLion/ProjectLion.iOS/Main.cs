using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ProjectLion.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UITabBar.Appearance.BarTintColor = UIColor.FromRGB(0x91, 0xCA, 0x47); // green
																				  // switch
			UINavigationBar.Appearance.BackgroundColor = UIColor.FromRGB(0x91, 0xCA, 0x47); // green

			UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
