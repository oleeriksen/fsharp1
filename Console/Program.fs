namespace Console
open System
module Main =


    (* This is a multi-line comment *)
    // This is a single-line comment

    let a = 10

    let IsEven n = (n % 2 = 0)

    let rec AList n =
        if n = 0 then []
        else  AList (n-1) @  [n]
             
    let IsPrime n = [2..n-1] |> Seq.forall(fun x -> printf "%d " x; n % x <> 0)

    let rec AListWithFilter n filter =
            if n = 0 then []
            elif  filter n then (AListWithFilter (n-1) filter) @ [n]
            else AListWithFilter (n-1) filter

    // exercise: solve exercise 1 from compulsory assignment in Contracts. 

    let TrueDivisors n = [2..n-1] |> List.filter (fun d -> n % d = 0)

    let rec TD2 n max =
            if n = 2 then []
            elif  max % n = 0 then (TD2 (n-1) max) @ [n]
            else TD2 (n-1) max

    let TrueDivisors2 n =  TD2 (n/2) n

    let main arg =
        //Console.WriteLine("Add7 4 = {0}", Example1.Add7 4)
        //Console.WriteLine("summa(4,2)= {0}", (Summa (4, 2)) );
        printfn "%s siger: De lige tal mellem 1 og 10 %A" arg (AListWithFilter 10 IsEven)
       
       //Console.WriteLine("sign {0}: {1}", Add 5, (sign (Add 5) ))
       //(AListExtended 10 IsEven) |> Seq.iter (fun x -> printf "%d " x);
        //(AListWithFilter 100 IsPrime) |> Seq.iter (fun x -> printf "%d " x)
        printfn "Primtal mellem 2 og 100 %A" (AListWithFilter 100 IsPrime) 
       //[1..10] |> Seq.iter (fun x -> printf "%d isEven %b " x (IsEven x))
      
    [<EntryPoint>]
    main "peter"