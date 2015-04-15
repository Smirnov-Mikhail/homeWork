type 'a Tree =
    | EmptyTree of 'a
    | Tree of 'a * 'a Tree * 'a Tree

let rec heightOfTree tree =
    match tree with
    | EmptyTree _ -> 1
    | Tree(_, l, r) ->
        1 + max (heightOfTree l) (heightOfTree r)

let tree = Tree(10, Tree(2, EmptyTree(1), EmptyTree(5)), EmptyTree(40));
printfn "%A" (heightOfTree tree)