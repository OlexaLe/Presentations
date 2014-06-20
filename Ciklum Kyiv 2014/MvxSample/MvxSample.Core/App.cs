using Cirrious.MvvmCross.ViewModels;

namespace MvxSample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize ()
        {
            RegisterAppStart<FirstViewModel> ();
        }
    }
}