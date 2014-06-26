using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Reflection;

namespace FormsSample
{
    public class HomePage
        : ContentPage
    {
        public HomePage ()
        {
            Title = "Start page";

            var navigateCommand = new Command<Type> (async (Type pageType) => {
                var constructors = pageType.GetTypeInfo ().DeclaredConstructors;
                foreach (var constructor in constructors) {
                    if (constructor.GetParameters ().Length == 0) {
                        var page = (Page)constructor.Invoke (null);
                        await Navigation.PushAsync (page);
                        break;
                    }
                }
            });
                        
            Content = new TableView {
                Intent = TableIntent.Menu,
                Root = new TableRoot {
                    new TableSection ("UI") {
                        new TextCell {
                            Text = "Controls",
                            Command = navigateCommand,
                            CommandParameter = typeof(ControlsPage)
                        },

                        new TextCell {
                            Text = "Rotation / Animation",
                            Command = navigateCommand,
                            CommandParameter = typeof(TabAnimationRotationPage)
                        }
                    }, 

                    new TableSection ("Not UI") {
                        new TextCell {
                            Text = "MVVM",
                            Command = navigateCommand,
                            CommandParameter = typeof(MvvmPage)
                        },

                        new TextCell {
                            Text = "Dependecy Injection",
                            Command = navigateCommand,
                            CommandParameter = typeof(DependecyPage)
                        }
                    }
                }
            };
        }
    }
}

