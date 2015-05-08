let oppositeClose a b =
    (a = '(' && b = ')') || (a = '{' && b = '}') || (a = '[' && b = ']')

let test (str: string) = 
    let stack = []
    let rec recTest stack (str: string) =
        if (List.length stack <> 0 && String.length str <> 0 && oppositeClose (List.head stack) str.[0]) then
            recTest (List.tail stack) str.[1..str.Length - 1]
        else if (str.Length <> 0) then
            recTest (str.[0]::stack) str.[1..str.Length - 1]    
        else (List.length stack) = 0          
    recTest stack str
            
printfn "%A" (test "(({}[]){})")

  