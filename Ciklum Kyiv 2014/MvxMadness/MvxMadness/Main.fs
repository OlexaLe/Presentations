namespace MvxMadness

open System

open MonoTouch.UIKit

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main (args, null, "AppDelegate")
        0