let FindPosition list =
    let rec recFindPosition list max iter =       
        match list with
        | head :: tail when (list.Length < 3) -> Some(iter)
        | head :: tail -> 
            if (max < head + tail.Tail.Head) then
                recFindPosition tail (head + tail.Tail.Head) (iter + 1)
            else
                recFindPosition tail max (iter + 1)
        | [] -> None
    recFindPosition list 0 0

printf "%A" (FindPosition [ 1; 5; 6; 2 ])