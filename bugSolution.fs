let mutable x = ref 10
let mutable y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y //Prints 20 10

//The solution uses the 'ref' keyword which allows the function to modify the original variables.
//The '!' dereferences the reference to get the value.