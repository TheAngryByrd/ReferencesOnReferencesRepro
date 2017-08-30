// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    Top.Say.hello "Top-CLR"
    Middle.Say.hello "Top-CLR"
    printfn "Hello World from F#!"
    0 // return an integer exit code
