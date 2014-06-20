
namespace MvxMadness

open System

open MonoTouch.UIKit
open MonoTouch.Foundation
open Cirrious.MvvmCross.Touch.Platform
open Cirrious.MvvmCross.Touch.Views.Presenters
open Cirrious.MvvmCross.ViewModels
open Cirrious.CrossCore
 
type Setup (applicationDelegate:MvxApplicationDelegate, presenter: IMvxTouchViewPresenter) = 
    inherit MvxTouchSetup(applicationDelegate,presenter )
    override u.CreateApp() = 
        new App():> IMvxApplication