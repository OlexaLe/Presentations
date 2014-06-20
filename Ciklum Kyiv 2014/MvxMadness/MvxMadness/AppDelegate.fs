namespace MvxMadness

open System
open MonoTouch.UIKit
open MonoTouch.Foundation
open Cirrious.MvvmCross.Touch.Platform
open Cirrious.MvvmCross.Touch.Views.Presenters
open Cirrious.MvvmCross.ViewModels
open Cirrious.CrossCore

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit MvxApplicationDelegate ()
 
    let window = new UIWindow (UIScreen.MainScreen.Bounds)
 
    override this.FinishedLaunching (app, options) =
        let presenter = new MvxTouchViewPresenter(this,window)

        let setup = new Setup(this, presenter)
        setup.Initialize()

        let startup = Mvx.Resolve<IMvxAppStart>()
        startup.Start()
        
        window.MakeKeyAndVisible ()
        true
