let isPrime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

let primes = Seq.initInfinite(fun i -> i + 2) |> Seq.filter isPrime

printfn "%A" primes