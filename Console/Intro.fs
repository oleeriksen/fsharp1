namespace Console

module Intro =

    // simple functions
   let Inc a = a + 1

   let Add a b = a + b

   let Add2 (a,b) = a+b

   let Add10 = Add 10

   // The following 2 functions are equal - as functions

   let AddAndInc = Add2 >> Inc;

   let AddAndInc2 (a,b) = Inc( Add2 (a,b))






   // function expressions

   let DaysOfMonth = function
        | 2 -> 28 // February
        | 4 -> 30 //April
        | 6 -> 30 //June
        | 9 -> 30 // September
        | 11 -> 30 // November
        | _ -> 31

   let DaysOfMonth2 = function
        | 2 -> 28 // February
        | 4|6|9|11 -> 30  //April
        | _ -> 31

   let rec fact = function
      | 0 -> 1
      | n when n > 0 -> n * fact(n-1)
      | _ -> -1


   let zero = 0

   let rec powerNo = function
            | (x,zero) -> 1.0                // This does NOT work
            | (x,n) -> x * powerNo(x,n-1)




   
   let rec power = function
      | (x, 0) -> 1.0         
      | (x, n) -> x * power(x,n-1)    
   
   let prefix = function
       | true -> "Mr."
       | false ->  "Ms."

   let prefixNormal isMale = 
           if isMale then "Mr."
                     else  "Ms."

   let SignAsText n = match n with
                      | t when t > 0 -> "Positive"
                      | 0 -> "Zero"
                      | _ -> "Negative"   








   // functions as parameters

   let AddS prefixStr baseStr = prefixStr + " " +  baseStr  

   let exclaim s = s + "!"


   let names = ["Peter"; "Betty"; "Donald"; "Susan"; "Chris"]

   let gender = [true; false; true; false; true]

   // how about making the list["Mr. Peter!", "Ms. Betty!", ... ??
   // each name prefixed with their gender and added a '!' to the end...




   let namesWithEx = List.map (fun s -> exclaim s) names

   let fully  = List.map2 (fun x y -> exclaim (AddS (prefix x)  y) ) gender names

   let fully2 = List.map2 (fun x y -> AddS (prefix x)  y |>  exclaim ) gender names

   // we can write out with prefix
   let output = List.iter2 (fun x y -> printf "%s %s !" (prefix x) y) gender names 

   let rec SumPos a = match a with
                      | [] -> 0
                      | x::rest when x > 0 -> x + SumPos rest
                      | x::rest -> SumPos rest 



   