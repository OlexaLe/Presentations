using System;
using Xamarin.Forms;

namespace FormsSample
{
    public class TabAnimationRotationPage
        : TabbedPage
    {
        public TabAnimationRotationPage ()
        {
            Title = "Animation / Rotation";

            Children.Add (new AnimationPage ());
            Children.Add (new RotationPage ());
        }
    }
}

