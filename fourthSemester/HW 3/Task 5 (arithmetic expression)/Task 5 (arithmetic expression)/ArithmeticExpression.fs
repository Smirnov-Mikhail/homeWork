type Tree<'a, 'b> =
    | Leaf of 'b
    | Tree of 'a * Tree<'a, 'b> * Tree<'a, 'b>

exception IncorrectOperation of string
exception DivisionByZero of string

let rec calculateTree tree =
    match tree with
    | Tree(operation, left, right) ->
        match operation with
        | '+' -> calculateTree left + calculateTree right
        | '-' -> calculateTree left - calculateTree right
        | '*' -> calculateTree left * calculateTree right
        | '/' ->
                if(calculateTree right = 0) then
                    raise (DivisionByZero "Division by zero")
                else
                    calculateTree left / calculateTree right
        | _ -> raise (IncorrectOperation "Incorrect operation!")
    | Leaf value -> value

let tree1 = Tree('*', Tree('+', Leaf(1), Leaf(2)), Leaf(3))

try
    printfn "%A" (calculateTree tree1)
with
    | IncorrectOperation(str) -> printfn "%s" str
    | DivisionByZero(str) -> printfn "%s" str

let tree2 = Tree('/', Tree('+', Leaf(1), Leaf(2)), Leaf(0))

try
    printfn "%A" (calculateTree tree2)
with
    | IncorrectOperation(str) -> printfn "%s" str
    | DivisionByZero(str) -> printfn "%s" str