function SortArray() {
    let size = parseInt(arguments[0]);
    let arr = arguments[1].split(" ");
    for(let i = 0 ; i< size ; i++){
        arr[i]=parseInt(arr[i]);
    }

    Print(Sort(arr));

    function Sort(arr){
        for(let i = 0 ; i<size-1 ; i++){
            let min = i;
            for(let j = i+1 ; j<size ; j++){
                if(arr[j]<arr[min]){
                    min=j;
                }
            }

            if(i!==min){
                let temp = arr[i];
                arr[i]=arr[min];
                arr[min]=temp;
            }
        }
        return arr;
    }

    function Print(arr){
        let sortedArrayInString = arr.join(" ");
        console.log(sortedArrayInString);
    }
}

SortArray('10', '36 10 1 34 28 38 31 27 30 20');
SortArray('6', '3 4 1 5 2 6');

