//HUSK DOCUMENTATION (summary, param, result)
//a
let sum n:int =
    if n < 1 then 
        0
    else
        let mutable s = 0
        let mutable i = 1 //counter 
        while i < n do
            s <- s + i 
            i <- i+1
        s 

printfn "%i" (sum(8))