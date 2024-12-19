let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 which is correct

//But if you try this
let swap2 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable a = ref 10
let mutable b = ref 20
swap2 a b
printf "%d %d" !a !b //This will print 10 20 which is wrong