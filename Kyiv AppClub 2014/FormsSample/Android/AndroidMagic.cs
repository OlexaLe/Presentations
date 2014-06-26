[assembly: Xamarin.Forms.Dependency (typeof(FormsSample.Android.AndroidMagic))]

namespace FormsSample.Android
{
    public class AndroidMagic
        :Java.Lang.Object, IMagic
    {
        public string DoMagic (string input)
        {
            return input.Replace ('X', 'G');
        }
    }
}

