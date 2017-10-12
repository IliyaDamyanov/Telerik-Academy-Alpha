function solve(args) {
    let hex = args[0];
    let numberTen = 0;
    let modifier = 10;
    let i =0;
    while(hex[i]!==undefined){
        switch(hex[i]){
            case 'A': numberTen += 10*modifier; break;
            case 'B': numberTen += 11*modifier; break;
            case 'C': numberTen += 12*modifier; break;
            case 'D': numberTen += 13*modifier; break;
            case 'E': numberTen += 14*modifier; break;
            case 'F': numberTen += 15*modifier; break;
            default : numberTen += parseInt(hex[i])*modifier ; break;
        }
        i++;
        modifier*=10;
    }
    console.log(numberTen);
}
solve(['FE'])