function solve() {
    let size = parseInt(arguments[0]);
    let arr = arguments[1].split(" ");
    for(let i = 0 ; i< size; i++){
        if(i===0 && +arr[0]>+arr[1]){
            return 0;
        }
        else if(i>0 && i< size-1 && +arr[i]>+arr[i-1] && +arr[i]>+arr[i+1]){
            return i;
        }
        else if(i=== size-1 && +arr[size-1]>+arr[size-2]){
            return i
        }
    }
    console.log('-1');
}

solve('6', '-26 -25 -28 31 2 27')