using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DatePickerTest
{
    public class Application
    {
        static void Main (string[] args)
        {
            UIApplication.Main (args, null, "AppDelegate");
        }

        [Register ("AppDelegate")]
        public partial class AppDelegate : UIApplicationDelegate
        {
            UIWindow window;
            UIDatePicker dp;

            public override bool FinishedLaunching (UIApplication app, NSDictionary options)
            {
                window = new UIWindow (UIScreen.MainScreen.Bounds);
                var vc = new UIViewController ();
                dp = new UIDatePicker ();
                dp.Mode = UIDatePickerMode.Date;
                dp.Mode = UIDatePickerMode.DateAndTime;
                dp.Mode = UIDatePickerMode.Time;
                dp.ValueChanged += delegate {
                    Console.WriteLine (dp.Date.ToString ());
                };
                vc.View.AddSubview (dp);

                window.AddSubview (vc.View);
                window.MakeKeyAndVisible ();

                return true;
            }
        }
    }
}
