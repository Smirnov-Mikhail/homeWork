let findElement list value =
    let rec recFind list value position = 
        match list with
        | head :: tail when head = value -> Some(position)
        | head :: tail when not (head = value) -> recFind tail value (position + 1)
        | [] -> None
    recFind list value 0

let AllElementsDifferent list =
    let rec recAllElementsDifferent list =       
        match list with
        | head :: tail when (list.Length < 2) -> Some(true)
        | head :: tail ->
            if (findElement tail head = None) then
                recAllElementsDifferent tail
            else
                Some(false)
        | [] -> None
    recAllElementsDifferent list

printfn "%A" (AllElementsDifferent [1; 2; 4; 0; 9])