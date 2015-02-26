let multiplyingNumberOfDigits number =
    let rec recMulty number =
        if (number > 0) then 
            (number % 10) * recMulty (number / 10)
        else
            1
    recMulty number