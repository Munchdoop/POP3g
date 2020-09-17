//HUSK DOCUMENTATION (summary, param, result)
//opgave 3g0 a)
/// <summary> Vi har lavet en funktion der lægger alle tal i talrækken sammen til og med n<\summary>
/// param
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

printfn "%i" (sum(5))

//3g0 b)
