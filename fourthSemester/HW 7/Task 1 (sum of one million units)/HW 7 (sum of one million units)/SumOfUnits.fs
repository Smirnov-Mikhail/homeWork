let sum items =
    let mutable result = 0
    for i in items do
        result <- result + i  
    result 

let sumOfArray sum (items: array<int>) =
    let tasks =         
        seq {            
            for i in 0..Array.length items / 10000 - 1 -> async  {                
                return (sum items.[i * 10000..(i + 1) * 10000 - 1])  
            }                    
        }
    sum (Async.RunSynchronously (Async.Parallel tasks))

let array = [| for i in 1 .. 1000000 -> 1 |]
// Результат вроде не странный...
printfn "%A" (sumOfArray sum array)