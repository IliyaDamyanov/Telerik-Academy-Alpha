function solve() {
    let contained = 0;
    let numbersInArray = parseInt(arguments[0]);
    let containedNumber = parseInt(arguments[2]); 
    let arr = arguments[1].split(" ");
    for(let i = 0; i< numbersInArray ; i++){
        if(parseInt(arr[i])===containedNumber){
            contained++;
        }
    }
    console.log(contained);
}

solve('8', '28 6 21 6 -7856 73 73 -56', '73')