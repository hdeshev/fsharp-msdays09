#light

let a = 3

//declaring a function
let sum a b = a + b

let c = sum 5 11
printfn "%d" c

//creating an anonymous function and giving it a name
let anonymousSum = (fun x y -> x + y)
printfn "%d" (anonymousSum 3 4)

//a function returning a function
let makeAdder x = 
    (fun y -> y + x)

let add3 = makeAdder 3
printfn "%d" (add3 5)

//declaring a mutable var
let mutable mutableNum = 3
//modifying its values
mutableNum <- 4
printfn "%d" mutableNum

let point = (2.0, 3.5)
//dismantling a tuple into two variables
let xCoord, yCoord = point
printfn "%A" point

//a new F# list
let myList = ["one"; "two"; "three"]
//a .NET array
let myArray = [|"one"; "two"; "three"|]

open System.Collections.Generic
//a .NET generic list of strings
let stringList = new List<string>()
stringList.Add("one")
stringList.Add("two")
stringList.Add("three")