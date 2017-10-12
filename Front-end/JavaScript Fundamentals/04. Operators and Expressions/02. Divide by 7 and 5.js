function solve(args) {
    let n = parseInt(args[0]);
    if(n%5===0 && n%7===0) {
        return 'true '+n;
    }
    else {
        console.log('false '+n);
    }
}