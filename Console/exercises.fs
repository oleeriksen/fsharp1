let g n = n + 4

let g2 = function
        n -> n+4

let g3 = function
        0 -> 0
       |n when n > 0 -> n+4
       |n -> n-4

let rec One2N = function
                  0 -> 0
                | m when m > 0 -> m + One2N (m-1)
                | _ -> -1

let rec Fib = function
             0 -> 0
             |1 -> 1
             |n -> Fib (n-1) + Fib (n-2)



