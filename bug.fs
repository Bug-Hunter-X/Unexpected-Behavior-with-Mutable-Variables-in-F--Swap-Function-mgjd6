let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //Prints 20 20

//The issue is that the swap function modifies the local copies of x and y, not the variables passed into the function.
//To correct this, you need to pass the variables by reference using the 'ref' keyword.