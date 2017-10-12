function solve(args) {
    let n = parseInt(args[0]);
    if(n%2===0) {
        return 'even '+n;
    }
    else {
        console.log('odd '+n);
    }
}

