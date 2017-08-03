using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.GoogleMaps;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


namespace ProjectLion.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            UINavigationBar.Appearance.BarTintColor=Color.FromHex("#d2d9db").ToUIColor();
            UINavigationBar.Appearance.TitleTextAttributes = new UIStringAttributes {ForegroundColor = UIColor.Black};
			global::Xamarin.Forms.Forms.Init();

            new Syncfusion.SfChart.XForms.iOS.Renderers.SfChartRenderer();
            Xuni.Forms.FlexGrid.Platform.iOS.Forms.Init();
            LoadApplication(new App());
            Xamarin.FormsGoogleMaps.Init("AIzaSyBVVs0r4ab2inlCJmkQyo8FC_97qSW8_JI");
            return base.FinishedLaunching(app, options);
        }
    }
}
