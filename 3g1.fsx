//3g1 a)
///<summary>We have a function that returns the multiplication tables up until the n'th multiplication table.</summary>
/// <param name="table">String containing multiplication tables from 1 to 10</param>
/// <param name="mulTable">Function taking an integer</param>
/// <param name="n">Input which is an integer</param>
/// <returns>If n is > 1 and < 10, it returns the multiplication tables up to and including the n'th table, else it returns an empty string</returns>
let table = "       1   2   3   4   5   6   7   8   9  10
   1   1   2   3   4   5   6   7   8   9  10
   2   2   4   6   8  10  12  14  16  18  20
   3   3   6   9  12  15  18  21  24  27  30
   4   4   8  12  16  20  24  28  32  36  40
   5   5  10  15  20  25  30  35  40  45  50
   6   6  12  18  24  30  36  42  48  54  60
   7   7  14  21  28  35  42  49  56  63  70
   8   8  16  24  32  40  48  56  64  72  80
   9   9  18  27  36  45  54  63  72  81  90
  10  10  20  30  40  50  60  70  80  90 100"
let mulTable (n:int) =
    if n < 0 || n > 10 then
        ""
    else
        table.[..(44+(n*46))-1] 
                                
printfn "%s" (mulTable(1))
printfn "%s" (mulTable(2))
printfn "%s" (mulTable(3))
printfn "%s" (mulTable(10))

//3g1 b)
///<summary>This is a function that first builds a string containing multiplication tables for 1 to 10, and afterwards returns the multiplication tables up to and including the (input) n'th table</summary>
/// <param name="loopMulTable">Function that that takes an integer n an input and builds the multiplication tables through a for loop nested in a for loop </param>
/// <param name="n">Input which is an integer</param>
/// <param name="res">Mutable which becomes the multiplation tables</param>
/// <param name="num">Mutable which the value i*j gets mapped to</param>
/// <param name="stringNum">Mutable which contains the number/index each multiplication table</param>
/// <param name="a">Integer which takes the input from the user and inputs it into mulTable and loopMultable</param>
/// <returns>If n < 1 or > 10 it returns the multiplication tables up to and including the n'th multiplation table, else it returns an empty string </returns>
let loopMulTable (n:int) =
    if n < 1 then
        ""
    elif n > 10 then
        ""
    else  
        // initialising res with the first line of multiplication table
        let mutable res = "       1   2   3   4   5   6   7   8   9  10"
        let mutable num = 0
        let mutable stringNum = "" 
        
        for i = 1 to n do
            res <- res + sprintf "\n%4d" i  // print newline + value of n
            for j = 1 to 10 do
                num <- i*j
                stringNum <- sprintf "%4d" num
                res <- res + stringNum
        res

printfn "%s" (loopMulTable(1))
printfn "%s" (loopMulTable(2))
printfn "%s" (loopMulTable(3))
printfn "%s" (loopMulTable(10))

printf "Enter a number: "
let a = int (System.Console.ReadLine())

printfn "mulTable: \n%s" (mulTable(a))
printfn "loopMulTable: \n%s" (loopMulTable(a))


//3g1c
///<summary>A function that compares the resulting strings of mulTable and loopMultable and returns a column containing n and true or false</summary>
/// <param name="a">An integer that is send to the functions mulTable and loopMulTable</param>
/// <returns>
printfn "%d || %b" a (mulTable(a) = loopMulTable(a))
//Should be returning True, but returns False for all n but 10.  
//We think the problem might be in the first table, something to do with the escape characters

//3g1d
printfn "%s" (mulTable(a))
printfn "%A" (mulTable(a))
(*%s prints mulTable as a string. and %A also prints a string because mulTable already returns a string.
With %s you are given a string placeholder which is replaced by the argument you give it, here the Multable result. 
With %A it converts any argument into a string, with a Fsharp internal function called ToString.*)