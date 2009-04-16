#light

let printData data = 
    match data with
        | (true, true) -> "both true"
        | (false, false) -> "both false"
        | (_, _) -> "different values"
        
        
printfn "%s" (printData (false, false))
printfn "%s" (printData (true, false))

let rec printList list =
    match list with
        | [] -> ""
        | [item] -> item.ToString()
        | head :: tail -> head.ToString() + ", " + printList tail
        
printfn "%s" (printList [1; 2; 3; 4])

type Optional<'a> =
    | Value of 'a
    | Empty
    
    
let printOptional option =
    match option with
        | Value x -> "Value: " + x.ToString()
        | Empty -> "Empty"
        
printfn "%s" (printOptional (Value 3))
printfn "%s" (printOptional (Empty))

let (|Even|Odd|) x =
    if x % 2 = 0 then
        Even
    else
        Odd
    
let printEvenOdd x = 
    match x with
        | Even -> "Even!"
        | Odd -> "Odd!"
        
printfn "%s" (printEvenOdd 3)
printfn "%s" (printEvenOdd 4)