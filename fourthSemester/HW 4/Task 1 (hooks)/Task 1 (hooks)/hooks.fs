let oppositeClose a b =
    (a = '(' && b = ')') || (a = '{' && b = '}') || (a = '[' && b = ']')

let test (str: string) = 
    let stack = []
    let rec recTest stack (str: string) index =
        if (List.length stack <> 0 && index < String.length str && oppositeClose (List.head stack) str.[index]) then
            recTest (List.tail stack) str (index + 1)
        else if (index < String.length str) then
            recTest (str.[index]::stack) str (index + 1)  
        else (List.length stack) = 0          
    recTest stack str 0
            
printfn "%A" (test "(({}[]){})")    

  