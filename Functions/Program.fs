#light

let sumThree x y z =
    x + y + z
    
let sumTwo5 = sumThree 5
let sumOne10 = sumTwo5 5
let result = sumOne10 5
printfn "%d" result

let doubled = List.map (fun x -> x * 2) [1; 2; 3]
printfn "%A" doubled

let doubledGreaterThan3 = 
    [1; 2; 3] 
        |> List.map (fun x -> x * 2)
        |> List.filter (fun x -> x > 3) 
        
printfn "%A" doubledGreaterThan3

let rec sum x =
    if x = 0 then
        0
    else
        x + sum (x - 1)
        
printfn "%A" (List.map sum [0; 1; 2; 3; 4; 5; 6])

//printfn "%d" (sum 100000)

let sumTail x =
    let rec sumWithAccumulator accumulator x =
        if x = 0 then
            accumulator
        else
            sumWithAccumulator (accumulator + x) (x - 1)
    sumWithAccumulator 0 x
            
printfn "%d" (sumTail 100000)