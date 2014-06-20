using Xamarin.Forms;

namespace FormsSample
{
    public class FirstView
        : ContentPage
    {
        public FirstView ()
        {
            BindingContext = new FirstViewModel ();

            var input = new Entry ();
            var magic = new Button { Text = "Do Magic" };
            var output = new Label { Text = "Test" };

            input.SetBinding (Entry.TextProperty, "Input");
            magic.SetBinding (Button.CommandProperty, "Magic");
            output.SetBinding (Label.TextProperty, "Output");

            Content = new StackLayout {
                Padding = new Thickness (0f, 20f, 0f, 0f),
                Children = {
                    input, magic, output
                }
            };
        }

    }
}

