let mulTable n:int =
    let array = ""
    if n < 1  then 
        0
    else
        let mutable s = 1
        let mutable i = 1 //counter 
        while i <= n do
            s <- s * i
            array = s
            i <- i+1
        s