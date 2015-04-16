open System
open System.IO
open System.Collections.Generic
open System.Text

let find data name number = 
    let isEqually element (str1: string, str2: string) = ((str1, str2) = element)
    try
          Some (List.find (isEqually (name, number)) data)
    with
          | :? System.Collections.Generic.KeyNotFoundException -> None

let findNumberByName data =
    printfn "Введите имя:"
    let name = Console.ReadLine()
    let isEqually (element: string) (str1: string, str2: string) = (str1 = element)
    try
        let result = List.find (isEqually name) data
        printfn "%A" (snd result)
        data
    with
        | :? System.Collections.Generic.KeyNotFoundException -> 
            printfn "%s" "Номер не найдён. Попробуйте ещё раз!"
            data
    

let findNameByNumber data =
    printfn "Введите номер телефона:"
    let number = Console.ReadLine()
    let isEqually (element: string) (str1: string, str2: string) = (str2 = element)
    try
        let result = List.find (isEqually number) data
        printfn "%A" (fst result)
        data
    with
        | :? System.Collections.Generic.KeyNotFoundException -> 
            printfn "%s" "Абонент не найдён. Попробуйте ещё раз!"
            data

let addElement data (name: string) (number: string) =
    if (find data name number <> None) then
        printfn "%s" "Такой абонент уже есть в справочнике. Попробуйте ещё раз!"
        data
    else
        let data = (name, number)::data
        data

let readFromFile data =
    try
        use input = File.OpenText "phonebook.txt"
        let rec readLines data =
            let name = input.ReadLine()
            let number = input.ReadLine()  
            match name with
            | null | "" ->
                data
            | _ ->
                let data = addElement data name number
                readLines data  
        let data = readLines data
        input.Close()
        data
    with
    | exn -> 
        printfn "%s" "Ошибка чтения из файла!"
        data
    
let rec startProcess data =
    printfn "Введите цифру от 0 до 5:
0 - выйти
1 - добавить запись (имя и телефон)
2 - найти телефон по имени
3 - найти имя по телефону
4 - сохранить текущие данные в файл
5 - считать данные из файла"
    let key = Console.ReadLine()
    Console.Clear()
    match key with
    | "0" ->
        printfn "Спасибо, что воспользовались услугами нашего справочника!"
    | "1" -> 
        printfn "Введите имя:"
        let name = Console.ReadLine()
        printfn "Введите номер телефона:"
        let number = Console.ReadLine()      
        startProcess (addElement data name number)
    | "2" ->
        startProcess (findNumberByName data)
    | "3" ->
        startProcess (findNameByNumber data)
    | "4" ->
        use output = File.CreateText "phonebook.txt"
        for i in data do
            output.WriteLine (fst i)
            output.WriteLine (snd i)   
        output.Close()
        startProcess data
    | "5" ->
        startProcess (readFromFile data)
    | _ -> 
        printfn "Данные введены неправильно. Попробуйте ещё раз !\n"
        startProcess data

let data = []
startProcess data