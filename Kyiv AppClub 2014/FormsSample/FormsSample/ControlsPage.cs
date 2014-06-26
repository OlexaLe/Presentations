using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace FormsSample
{
    public class ControlsPage
        : ContentPage
    {
        public ControlsPage ()
        {
            Title = "Controls";

            Content = new ScrollView {
                Padding = new Thickness (10),

                Content = new StackLayout {
                    Children = {
                        GetLabel (),
                        GetButton (),
                        GetBoxView (),
                        GetContentView (),
                        GetDatePicker (),
                        GetTimePicker (),
                        GetEntry (),
                        GetImage (),
                        GetPicker (),
                        GetSlider (),
                        GetSwitch ()
                    }
                }
            };
        }

        Label GetLabel ()
        {
            return new Label {
                Text = "Label",
                Font = Font.BoldSystemFontOfSize (50),
                HorizontalOptions = LayoutOptions.End
            };
        }

        Button GetButton ()
        {
            return new Button {
                Text = "Button",
                TextColor = Color.Red,
                Command = new Command (() => {
                }),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }

        BoxView GetBoxView ()
        {
            return new BoxView {
                Color = Color.Accent,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }

        ContentView GetContentView ()
        {
            return new ContentView {
                BackgroundColor = Color.Aqua,
                Padding = new Thickness (25),
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = new Label {
                    Text = "The ContentView (colored aqua in this " +
                    "example) might not seem very useful " +
                    "because it can have a single child " +
                    "(in this example a Label) and doesn't " +
                    "do much else. But ContentView is sometimes a " +
                    "convenient way of providing a background " +
                    "color or giving a little margin to its " +
                    "child through its own Padding property.",
                    TextColor = Color.Purple
                }
            };
        }

        DatePicker GetDatePicker ()
        {
            return new DatePicker {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }

        TimePicker GetTimePicker ()
        {
            return new TimePicker {
                Format = "T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }

        Editor GetEditor ()
        {
            return new Editor {
                VerticalOptions = LayoutOptions.FillAndExpand
            };
        }

        Entry GetEntry ()
        {
            return new Entry {
                Keyboard = Keyboard.Email,
                Placeholder = "Enter email address",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }

        Image GetImage ()
        {
            return new Image {
                Source = ImageSource.FromUri (new Uri ("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }

        Picker GetPicker ()
        {
            var nameToColor = new Dictionary<string, Color> {
                { "Aqua", Color.Aqua },         { "Black", Color.Black },
                { "Blue", Color.Blue },         { "Fuschia", Color.Fuschia },
                { "Gray", Color.Gray },         { "Green", Color.Green },
                { "Lime", Color.Lime },         { "Maroon", Color.Maroon },
                { "Navy", Color.Navy },         { "Olive", Color.Olive },
                { "Purple", Color.Purple },     { "Red", Color.Red },
                { "Silver", Color.Silver },     { "Teal", Color.Teal },
                { "White", Color.White },       { "Yellow", Color.Yellow }
            };
            var picker = new Picker {
                Title = "Color Picker",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            foreach (string colorName in nameToColor.Keys) {
                picker.Items.Add (colorName);
            }
            return picker;
        }

        Slider GetSlider ()
        {
            return new Slider {
                Minimum = 0,
                Maximum = 100,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }

        Switch GetSwitch ()
        {
            return new Switch {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}

