let rec fibonacci n =
    match n with
    |  1 | 2 -> 1
    | _-> fibonacci(n - 1) + fibonacci (n - 2)