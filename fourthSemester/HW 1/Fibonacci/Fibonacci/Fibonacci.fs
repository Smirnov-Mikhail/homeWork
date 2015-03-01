let rec fibonacci n =
    match n with
    | n when n < 0 -> None
    | 1 | 2 -> Some(1)
    | n -> fibonacci(n - 1) + fibonacci (n - 2)