namespace MvxMadness

open System

open Cirrious.CrossCore.IoC
open Cirrious.MvvmCross.ViewModels

type internal ComplexLogic() =
    member this.Reverse (s:string) = new string(s |> Seq.toArray |> Array.rev)

type FirstViewModel() = 
    inherit MvxViewModel()

    let mutable input : string = "F# Madness"
    let mutable output : string = ""
    let logic = new ComplexLogic()

    member this.Input
        with get () = input
        and set (value) = 
            input <- value 
            this.RaisePropertyChanged "Input"

    member this.Output
        with get () = output
        and set (value) =         
            output <- value 
            this.RaisePropertyChanged "Output"
    
    member private this.DoMagic () =
            this.Output <- logic.Reverse(this.Input)
    
    member this.Magic
        with get () =
            new MvxCommand (fun () -> this.DoMagic())