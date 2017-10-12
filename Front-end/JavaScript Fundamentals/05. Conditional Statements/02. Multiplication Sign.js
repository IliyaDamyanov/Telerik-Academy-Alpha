function solve(args) {
    let a = parseFloat(args[0]);
    let b = parseFloat(args[1]);
    let c = parseFloat(args[2]);
    if(a===0 || b===0 || c===0){
        console.log(0);
    }
    else if(a<0 ^ b<0 ^ c<0){
        console.log('-');
    }
    else if(a<0 && b<0 && c<0){
        console.log('-');
    }
    else{
        console.log('+');
    }
}