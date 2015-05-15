let findPosition list =
    let rec recFindPosition list max iter result =       
        match list with
        | head :: tail when tail <> [] -> 
            if (max < head + tail.Head) then
                recFindPosition tail (head + tail.Head) (iter + 1) iter
            else
                recFindPosition tail max (iter + 1) result
        | _ -> result
        
    recFindPosition list 0 0 -1

printf "%A" (findPosition [1; 5; 6; 2; 11])