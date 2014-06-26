using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace FormsSample
{
    public class AnimationPage
        : ContentPage
    {
        public AnimationPage ()
        {
            Title = "Animation";

            var box = new BoxView {
                WidthRequest = 100,
                HeightRequest = 100,
                Color = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center
            };

            var button = new Button {
                Text = "Animate!"
            };

            button.Clicked += async(s, e) => {
                button.IsEnabled = false;
                box.Color = Color.Blue;

                var originalPosition = box.Bounds;
                var newPosition = box.Bounds;
                newPosition.Y = Height - box.Height;

                await box.LayoutTo (newPosition, 2000, Easing.BounceOut);

                box.Color = Color.Red;
                await Task.WhenAll (
                    box.FadeTo (0, 2000),
                    box.ScaleTo (2, 2000));

                box.Color = Color.Aqua;
                await Task.WhenAll (
                    box.FadeTo (1, 2000),
                    box.ScaleTo (1, 2000));

                box.Color = Color.Blue;
                await box.LayoutTo (originalPosition, 2000, Easing.Linear);

                box.Color = Color.Yellow;
                button.IsEnabled = true;
            };

            Content = new StackLayout {
                Children = {
                    button, box
                }
            };
        }
    }
}

