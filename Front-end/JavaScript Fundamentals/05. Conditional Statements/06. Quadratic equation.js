function solve(args) {
    let a = parseFloat(args[0]);
    let b = parseFloat(args[1]);
    let c = parseFloat(args[2]);
    let D = b*b-4*a*c;
    if(D<0){
        console.log('no real roots');
    }
    else if(D===0){
        let x1 = -b/(2*a);
        console.log('x1=x2=' + x1.toFixed(2));
    }
    else if(D>0){
        let x1 = (-b-Math.sqrt(D))/(2*a);
        let x2 = (-b+Math.sqrt(D))/(2*a);
        console.log(`x1=${x1.toFixed(2)}; x2=${x2.toFixed(2)}`);
    }
}