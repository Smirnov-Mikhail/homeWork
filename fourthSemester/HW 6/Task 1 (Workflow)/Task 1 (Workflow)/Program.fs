type RoundingBuilder(digit : int) =

    member this.Bind (x : float, rest : float -> float) =
        System.Math.Round(rest x, digit)

    member this.Return x = x

let rounding digit = RoundingBuilder digit