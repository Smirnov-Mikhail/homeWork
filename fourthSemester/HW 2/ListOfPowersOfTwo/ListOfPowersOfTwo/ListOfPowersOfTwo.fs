let createList2 startPow =
    let list = [startPow]
    let collectList = List.collect (fun x -> [for i in 0..4 -> x * (2.0 ** float(i))]) list
    collectList