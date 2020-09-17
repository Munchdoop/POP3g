//HUSK DOCUMENTATION (summary, param, result)
//opgave 3g0 a)
/// <summary> A function has been made that sums all the numbers from i=1 to n<\summary>
/// <param>
/// <remarks> 
/// <result> The function return the sum of all the numbers 
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

//printfn "%i" (sum(8))

//3g0 b)
//The function returns the same result as the summation of all the numbers (1 + 2 + 3..+ n)
let simplesum n:int =
    if n < 0 then 
        0
    else 
        let mutable s = 0 
        s <- (n*(n+1))/2
        s 

//printfn "%i" (simplesum(8))

//3g0 c)
printf "Enter a Number:"
let a = int (System.Console.ReadLine())
printfn "%i %i" (simplesum(a)) (sum(a))

