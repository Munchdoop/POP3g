//HUSK DOCUMENTATION (summary, param, result)
//opgave 3g0 a)
/// <summary> Vi har lavet en funktion der lægger alle tal i talrækken sammen til og med n<\summary>
/// <param>
/// <remarks> 
/// <result> 
let sum n:int =
    if n < 1 then 
        0
    else
        let mutable s = 0
        let mutable i = 1 //counter 
        while i <= n do
            s <- s + i 
            i <- i+1
        s 

printfn "%i" (sum(8))

//3g0 b)
//
let simplesum n:int =
    if n < 0 then 
        0
    else 
        let mutable s = 0 
        s <- (n*(n+1))/2
        s 

printfn "%i" (simplesum(8))


