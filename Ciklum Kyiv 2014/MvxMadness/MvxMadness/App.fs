namespace MvxMadness

open System

open Cirrious.CrossCore.IoC
open Cirrious.MvvmCross.ViewModels

type App ()  = 
    inherit Cirrious.MvvmCross.ViewModels.MvxApplication()
    override u.Initialize() = 
        u.RegisterAppStart<FirstViewModel>()

