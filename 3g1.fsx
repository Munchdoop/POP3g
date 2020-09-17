let f (n:int) =
    let str1 = "   1 2 3 4 5 6 7 8 9 10
1 1 2 3 4 5 6 7 8 9 10
2 2 4 6 8 10 12 14 16 18 20
3 3 6 9 12 15 18 21 24 27 30
4 4 8 12 16 20 24 28 32 36 40"
    let str2 = str1.[0..n*10]
    
printfn "%s" (f(3))
 


//løsningsforslag til a og b 
//3g1 a) VIRKER IKKE HELT
let tabel = "1 2 3 4 5 6 7 8 9 10
2 4 6 8 10 12 14 16 18 20
3 6 9 12 15 18 21 24 27 30
4 8 12 16 20 24 28 32 36 40
5 10 15 20 25 30 35 40 45 50
6 12 18 24 30 36 42 48 54 60
7 14 21 28 35 42 49 56 63 70
8 16 24 32 40 48 56 64 72 80
9 18 27 36 45 54 63 72 81 90
10 20 30 40 50 60 70 80 90 100"
let mulTab (n:int) =
    if n < 1 || n > 10 then 
        ""
    else 
        tabel.[..n*10] 
printfn "%s" (mulTab(2))


//3g1 b)
let mulTable (n:int) =
    if n < 1 then
        ""
    elif n > 10 then
        ""
    else
        let mutable res = ""
        let mutable num = 0
        let mutable stringNum = "" 
        for i=1 to n do
            for j = 1 to 10 do
                num <- i*j
                stringNum <- string num
                res <- res + stringNum + " "
            res <- res + "\n"
        res

        

printfn "%s" (mulTable(3))


