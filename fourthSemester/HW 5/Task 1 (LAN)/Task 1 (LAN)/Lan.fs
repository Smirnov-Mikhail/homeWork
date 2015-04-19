open System

let rand = Random()

type Computer =
    {mutable infected: bool; probabilityOfInfection: int; connectedComputers: List<int>}
    member v.IsInfected = v.infected
    member v.ProbabilityOfInfection = v.probabilityOfInfection
    member v.ConnectedComputers = v.connectedComputers

let rec recAllInfected(computers: List<Computer>) =
    if (computers.[0].IsInfected = false) then
        false
    else if (computers.Length = 1) then
        true
    else
        recAllInfected (List.tail computers)

type Lan(computers: List<Computer>) = 
    member v.computers = computers
    member v.allInfected =
        recAllInfected v.computers
    member v.makeMove =
        let mutable numbersOfNewInfections = []
        let mutable currentPosition = -1
        // Пройдём по всем компьютерам и "попытаемся" заразить компы, соседствующие с заражёнными.
        for i in computers do
            // Если кмопьютер заражён.
            if (i.IsInfected = true) then
                // Пройдёмся по всем компьютерам контактирующим с ним.
                for j in i.ConnectedComputers do
                    // Если компьютер не заражён, то с определённой вероятностью будет заражён.
                    if (computers.[j].IsInfected = false) then
                        let temp = rand.Next(100) + 1
                        if (temp < computers.[j].ProbabilityOfInfection) then
                            numbersOfNewInfections <- j::numbersOfNewInfections
                            currentPosition <- currentPosition + 1
             
        for i in 0..currentPosition do
            if (computers.[numbersOfNewInfections.[i]].IsInfected = false) then
                computers.[numbersOfNewInfections.[i]].infected <- true

let computer0 = {infected = true; probabilityOfInfection = 50; connectedComputers = [1]}
let computer1 = {infected = false; probabilityOfInfection = 50; connectedComputers = [2; 3;]}
let computer2 = {infected = false; probabilityOfInfection = 50; connectedComputers = [0; 3]}
let computer3 = {infected = false; probabilityOfInfection = 50; connectedComputers = [2; 4;]}
let computer4 = {infected = false; probabilityOfInfection = 50; connectedComputers = [0; 1; 2; 3]}

let computers = [computer0; computer1; computer2; computer3; computer4]
let Lan = Lan(computers)

while (recAllInfected computers <> true) do
    Lan.makeMove

for i in computers do
    printfn "%A" i.infected  