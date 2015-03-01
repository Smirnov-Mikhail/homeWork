let formListOfPowersOfTwo startPower =
    let list = []
    let rec recFormList list currentPow iter =
        if iter <> 5 then
            let list = list @ [currentPow]
            recFormList list (currentPow * 2) (iter + 1)
        else
            list
    recFormList list startPower 0