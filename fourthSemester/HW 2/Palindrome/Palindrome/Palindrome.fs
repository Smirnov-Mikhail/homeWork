let rec isPalindrome (str: string) =
    if (str.Length <= 1) then
        true
    else if (str.[0] = str.[str.Length - 1]) then
        isPalindrome str.[1..str.Length - 2]
    else
        false