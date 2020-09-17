//HUSK DOCUMENTATION (summary, param, result)
//opgave 3g0 a)
/// <summary> A function has been made that sums all the numbers from i=1 to n</summary>
/// <param> 
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

//3g0 b)
/// <summary> We have made a function which uses the formula in figure 3 to find to summation of n </summary>
/// <param>
/// <returns> The function returns the summation of n, the same result as in the sum function </returns>
//The function returns the same result as the summation of all the numbers (1 + 2 + 3..+ n)
let simpleSum n:int =
    if n < 0 then 
        0
    else 
        let mutable s = 0 
        s <- (n*(n+1))/2
        s 

//3g0 c)
/// <summary> This program asks the user for af Number and returns the summation calculated in sum og simpleSum </summary>
/// <param>
/// <returns> The program returns the values of the summation of n calculated in the sum og simpleSum function </returns>
printf "Enter a Number:"
let a = int (System.Console.ReadLine())
printfn "sum = %i, simpleSum = %i" (sum(a)) (simpleSum(a))

//3g0 d) 
/// <summary> 
/// <param>
/// <returns>
printfn "n sum simplesum"
for i = 1 to 10 do 
    printfn "%d | %d | %d" i (sum(i)) (simpleSum(i)) 

//3g0 e)
(* 
The largest n both functions can calculate is 46340. because simplesum multiplies input.
therefore the largest value must be lower than the square value of int32 max value. 
However the sum function can calculate up to 65535 because it uses addition instead of multiplication

Yes the functions can be modified by using uint64 instead of int32 which is the default in F#. We can use
uint64 because we do not have any negative values

*)
