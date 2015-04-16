type 'a Tree =
    | Leaf of 'a
    | Tree of 'a * 'a Tree * 'a Tree

let rec heightOfTree tree =
    match tree with
    | Leaf _ -> 1
    | Tree(_, l, r) ->
        1 + max (heightOfTree l) (heightOfTree r)

let tree = Tree(10, Tree(2, Leaf(1), Leaf(5)), Leaf(40));
printfn "%A" (heightOfTree tree)