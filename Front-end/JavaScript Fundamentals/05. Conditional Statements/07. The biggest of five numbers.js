function solve(args) {
    let a = parseFloat(args[0]);
    let b = parseFloat(args[1]);
    let c = parseFloat(args[2]);
    let d = parseFloat(args[3]);
    let e = parseFloat(args[4]);
    if(a>=b && a>=c && a>=d && a>=e){
        console.log(a);
    }
    else if(b>=a && b>=c && b>=d && b>=e){
        console.log(b);
    }
    else if(c>=a && c>=b && c>=d && c>=e){
        console.log(c);
    }
    else if(d>=a && d>=b && d>=c && d>=e){
        console.log(d);
    }
    else if(e>=a && e>=b && e>=c && e>=d){
        console.log(e);
    }
}