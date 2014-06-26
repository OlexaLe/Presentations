[assembly: Xamarin.Forms.Dependency (typeof(FormsSample.iOS.IOSMagic))]

namespace FormsSample.iOS
{
    public class IOSMagic
        : IMagic
    {
        public string DoMagic (string input)
        {
            return input.Replace ('X', 'J');
        }
    }
}

