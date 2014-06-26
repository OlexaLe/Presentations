using Xamarin.Forms;

namespace FormsSample
{
    public class MvvmPage
        : ContentPage
    {
        public MvvmPage ()
        {
            BindingContext = new MvvmPageViewModel ();

            var input = new Entry ();
            var magic = new Button { Text = "Do Magic" };
            var output = new Label { Font = Font.SystemFontOfSize (24) };

            input.SetBinding (Entry.TextProperty, "Input");
            magic.SetBinding (Button.CommandProperty, "Magic");
            output.SetBinding (Label.TextProperty, "Output");

            Title = "Model View ViewModel";

            Content = new StackLayout {
                Padding = new Thickness (20),
                Children = {
                    input, magic, output
                }
            };
        }

    }
}

