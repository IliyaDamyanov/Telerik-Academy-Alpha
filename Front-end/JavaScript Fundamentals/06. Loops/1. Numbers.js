function solve(args) {
    let n = parseInt(args[0]);
    let s= '';
    for(i=1; i<n; i++){
        s+=i+' ';
    }
    s+=i;
    console.log(s);
}