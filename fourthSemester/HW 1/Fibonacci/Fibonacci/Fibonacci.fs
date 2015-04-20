let sumOption (x1 : int option) (x2 : int option) =
    match x1 with
    | Some x -> x + 
                match x2 with
                | Some x -> x
                | None -> 0
    | None -> 0

let rec fibonacci n =
    match n with
    | n when n < 0 -> None
    | 0 -> Some(0)
    | 1 -> Some(1)
    | n -> Some(sumOption (fibonacci(n - 1)) (fibonacci (n - 2)))