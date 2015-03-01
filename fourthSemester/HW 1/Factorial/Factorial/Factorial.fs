let rec factorial n acc =
    if n < 0 then None
    elif n = 0 then Some(acc)
    else
       factorial (n - 1) (n * acc)