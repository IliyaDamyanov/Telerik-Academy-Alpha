function thirdDigit(args) {
    let n = parseInt(args[0]);
    let m;
    m = parseInt(n/10);
    m = parseInt(m/10)
    let number = m%10;
    if(number ===7){
        console.log('true');
    }
    else{
        console.log('false '+ number);
    } 
}