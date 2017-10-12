function solve(args) {
    let n = parseInt(args[0]);
    let finalString = '';
    let m = n
    for(i=0; i<n; i++){
        for(j=i+1; j<=m; j++){
            if(j===m){
                finalString += j;
                continue;
            }
            finalString += j + ' ';
        }
        finalString+='\n';
        m++;
    }
    console.log(finalString);
}