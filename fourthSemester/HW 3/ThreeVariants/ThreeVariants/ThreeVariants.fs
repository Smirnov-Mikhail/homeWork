let amountOfNumbers1 list =
    List.sum (List.map (fun x -> (x + 1) % 2) list)

let amountOfNumbers2 list =
   List.length (List.filter (fun x -> x % 2 = 0) list)

let amountOfNumbers3 list =
    List.fold (fun acc x -> acc - x % 2 + 1) 0 list

let list = [1; 2; 3; 4; 5; 0; 22]
printfn "%A" (amountOfNumbers1 list)
printfn "%A" (amountOfNumbers2 list)
printfn "%A" (amountOfNumbers3 list)