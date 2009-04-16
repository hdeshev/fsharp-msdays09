#light

let printData data = 
    match data with
        | (true, true) -> "both true"
        | (true, false) -> "true, false"
        | (false, true) -> "false, true"
        | (false, false) -> "both false"
        
printfn "%s" (printData (false, false))

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