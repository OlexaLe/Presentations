namespace MvxMadness

open System
open System.Drawing

open MonoTouch.UIKit
open MonoTouch.Foundation

open Cirrious.MvvmCross.Binding
open Cirrious.MvvmCross.Binding.BindingContext
open Cirrious.MvvmCross.Touch.Views
 
 
[<Register ("FirstView")>]
type FirstView () =
    inherit MvxViewController ()
   
    let label = new UILabel()
    let button = new UIButton (UIButtonType.RoundedRect)
    let textField = new UITextField() 

    override this.ViewDidLoad () =
        base.ViewDidLoad ()

        this.View.BackgroundColor <- UIColor.White

        textField.Frame <- new RectangleF(10.0f,70.0f,320.0f,40.0f)
        this.Add(textField)

        button.Frame <- new RectangleF(10.0f,110.0f, 300.0f, 40.0f)
        button.SetTitle ("Do Magic", UIControlState.Normal)
        this.Add(button)

        label.Frame <- new RectangleF(10.0f,150.0f,300.0f,40.0f)
        this.Add(label)
        
        let set  =  MvxBindingContextOwnerExtensions.CreateBindingSet<FirstView,FirstViewModel>(this)
        set.Bind(textField).To("Input") |> ignore
        set.Bind(button).To("Magic") |> ignore
        set.Bind(label).To("Output") |> ignore
        set.Apply()
