let func0 n list = List.map(fun x -> x * n) list
let func1 n = List.map(fun x -> x * n)
let func2 n = List.map((*) n)
let func3 = List.map << (*)