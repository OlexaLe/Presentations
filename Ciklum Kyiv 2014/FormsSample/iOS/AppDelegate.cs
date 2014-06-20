using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;

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
            window.MakeKeyAndVisible ();
			
            return true;
        }
    }
}

