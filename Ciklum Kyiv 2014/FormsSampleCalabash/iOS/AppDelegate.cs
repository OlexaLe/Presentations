using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using System.Diagnostics;

namespace FormsSample.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            Forms.Init ();

            window = new UIWindow (UIScreen.MainScreen.Bounds);
			
            window.RootViewController = App.GetMainPage ().CreateViewController ();
            InitialiseCalabash ();
            window.MakeKeyAndVisible ();
			
            return true;
        }

        [Conditional ("DEBUG")]
        static void InitialiseCalabash ()
        {
            Xamarin.Calabash.Start ();
        }
    }
}

