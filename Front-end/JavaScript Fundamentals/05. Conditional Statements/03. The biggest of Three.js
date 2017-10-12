function solve(args) {
    let a = parseFloat(args[0]);
    let b = parseFloat(args[1]);
    let c = parseFloat(args[2]);
    if(a>=b && a>=c){
        console.log(a);
    }
    else if(b>=a && b>=c){
        console.log(b);
    }
    else if(c>=a && c>=b){
        console.log(c);
    }
}