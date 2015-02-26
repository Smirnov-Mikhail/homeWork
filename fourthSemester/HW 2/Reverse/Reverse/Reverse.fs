let revList list  =
    let rec reverse list result =
        match list with
        | [] -> result
        | head :: tail -> reverse tail (head :: result)
    reverse list []