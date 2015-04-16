type Expression =
    | Addition of Expression * Expression
    | Subtraction of Expression * Expression
    | Multiplication of Expression * Expression
    | Division of Expression * Expression
    | Const of float
    | Variable
 
let rec calcDerivate expr =
    match expr with
    | Addition(expr1, expr2) -> Addition(calcDerivate expr1, calcDerivate expr2)
    | Subtraction(expr1, expr2) -> Subtraction(calcDerivate expr1, calcDerivate expr2)
    | Multiplication(expr1, expr2) -> 
        Addition(Multiplication(calcDerivate expr1, expr2), Multiplication(expr1, calcDerivate expr2))
    | Division(expr1, expr2) -> 
        Division(Subtraction(Multiplication(calcDerivate expr1, expr2), Multiplication(expr1, calcDerivate expr2)), Multiplication(expr2, expr2))
    | Const number -> Const(0.0)
    | Variable -> Const(1.0)

let rec simplification expr =
    match expr with
    | Addition(expr1, expr2) ->
        match (expr1, expr2) with
        | (Const(0.0), _) -> expr2
        | (_, Const(0.0)) -> expr1
        | (Const(number1), Const(number2)) -> Const(number1 + number2)
        | _ -> Addition(simplification expr1, simplification expr2)
    | Subtraction(expr1, expr2) ->
        match (expr1, expr2) with
        | (Const(0.0), _) -> Multiplication(Const(-1.0), expr2)
        | (_, Const(0.0)) -> expr1
        | (Const(number1), Const(number2)) -> Const(number1 - number2)
        | _ -> Subtraction(simplification expr1, simplification expr2)
    | Multiplication(expr1, expr2) ->
        match (expr1, expr2) with
        | (Const(0.0), _) | (_, Const(0.0)) -> Const(0.0)
        | (Const(1.0), _) -> expr2
        | (_, Const(1.0)) -> expr1
        | (Const(number1), Const(number2)) -> Const(number1 * number2)
        | _ -> Multiplication(simplification expr1, simplification expr2)
    | Division(expr1, expr2) ->
        match (expr1, expr2) with
        | (Const(0.0), _) -> Const(0.0)
        | (_, Const(1.0)) -> expr1
        | (Const(number1), Const(number2)) -> Const(number1 / number2)
        | _ -> Division(simplification expr1, simplification expr2)
    | Const number -> Const number
    | Variable -> Variable