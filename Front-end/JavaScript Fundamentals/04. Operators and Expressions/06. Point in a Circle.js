function solve(args) {
    let x = parseFloat(args[0]);
    let y = parseFloat(args[1]);
    let distance = Math.sqrt(x*x + y*y);
    if(distance<2){
        console.log('yes '+distance)
    }
    else{
        console.log('no '+distance)
    }
}