let findElement list value =
    let rec recFind list value position = 
        match list with
        | head :: tail when head = value -> Some(position)
        | head :: tail when not (head = value) -> recFind tail value (position + 1)
        | [] -> None
    recFind list value 0