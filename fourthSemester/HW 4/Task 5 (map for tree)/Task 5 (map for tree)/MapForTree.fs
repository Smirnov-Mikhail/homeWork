type 'a Tree =
    | Leaf of 'a
    | Tree of 'a * 'a Tree * 'a Tree

let rec mapForTree func tree =
    match tree with
    | Tree(node, left, right) -> Tree(func node, mapForTree func left, mapForTree func right)
    | Leaf node -> Leaf(func node)
