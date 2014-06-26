using Xamarin.Forms;

namespace FormsSample
{
    public class DependecyPage
        : ContentPage
    {
        public DependecyPage ()
        {
            var input = new Entry { Text = "Xamarin.Forms" };
            var magic = new Button { Text = "Do Magic" };
            var output = new Label { Font = Font.SystemFontOfSize (24) };

            magic.Clicked += (s, e) => {
                output.Text = DependencyService.Get<IMagic> ().DoMagic (input.Text);
            };

            Title = "Magic";

            Content = new StackLayout {
                Padding = new Thickness (20),
                Children = {
                    input, magic, output
                }
            };
        }
    }
}

