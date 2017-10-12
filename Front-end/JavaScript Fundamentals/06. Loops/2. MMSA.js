function solve(args) {
    let arr = [];
    let min = 0;
    let max = 0;
    let sum = 0;

    for(i=0; i<args.length; i++){
        arr[i]=parseFloat(args[i]);       
        if(i===0){
            min = arr[0];
            max = arr[0];
            sum += arr[0];
        }
        else{
            if(arr[i] <= min){
                min = arr[i];
                sum += arr[i];
            }
            else if(arr[i] >= max){
                max = arr[i];
                sum += arr[i];
            }      
        }     
    }
    console.log(`
    min=${min.toFixed(2)}
    max=${max.toFixed(2)}
    sum=${sum.toFixed(2)}
    avg=${(sum/args.length).toFixed(2)}`);
}