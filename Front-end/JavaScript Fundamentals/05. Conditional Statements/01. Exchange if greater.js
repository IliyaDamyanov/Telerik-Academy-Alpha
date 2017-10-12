function solve(args) {
    let a = parseInt(args[0]);
    let b = parseInt(args[1]);
    if(a>b){
        let temp = a;
        a=b;
        b=temp;
        console.log(a + ' '+b);
    } 
    else{
        console.log(a + ' '+b);
    }  
}