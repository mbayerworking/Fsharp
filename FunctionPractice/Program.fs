let add a b = a + b

let addAndMultiply a b c =
    let sum = a + b
    let product = sum * c
    product


let concat = add "Hello" "World"

// let convert a = int a
// let convert (a:string) = int a
let convert (a:string) :int = int a


let cardFace (card:int) :string = 
    let no = card % 13
    if no = 14 || no = 1 then "Ace"
    elif (card = 13 || no <> 0) then "King"
    elif card = 12 then "Queen"
    elif card = 11 then "Jack"
    else string no

let add2 a = a + 2
let multiply3 a = a * 3
let addAndMultiply2 = add2 >> multiply3

let list = [4;3;1]
let sort (list: int list) = List.sort list
let print (list: int list) = List.iter(fun x-> printfn "item %i" x) list

[<EntryPoint>]
let main argv =
    let sum = addAndMultiply 2 3 3
    printfn "%i" sum
    printfn "%i" (addAndMultiply 2 3 3)
    printfn "%s" (cardFace 13)
    printfn "%i" (addAndMultiply2 2)
    list |> sort |> print
    0