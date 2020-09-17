//HUSK DOCUMENTATION (summary, param, result)
//opgave 3g0 a)
/// <summary> A function has been made that sums all the numbers from i=1 to n<\summary>
/// <param>
/// <remarks> 
/// <returns> The function return the sum of all the numbers </returns> 
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
let simpleSum n:int =
    if n < 0 then 
        0
    else 
        let mutable s = 0 
        s <- (n*(n+1))/2
        s 

//printfn "%i" (simpleSum(8))

//3g0 c)
printf "Enter a Number:"
let a = int (System.Console.ReadLine())
printfn "sum = %i, simpleSum = %i" (sum(a)) (simpleSum(a))

//3g0 d) 
printfn "n sum simplesum"
for i = 1 to 10 do 
    printfn "%d | %d | %d" i (sum(i)) (simpleSum(i)) 

//3g0 e)
(**)
