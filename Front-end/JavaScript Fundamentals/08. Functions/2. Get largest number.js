function LargestNumber(args) {
    function GetMax(firstNumber , secondNumber){
        return (firstNumber >= secondNumber ? firstNumber : secondNumber)
    }
    let arr = [];
    arr=args.split(" ");
    let biggestNumber = GetMax(+arr[0], GetMax(+arr[1],+arr[2]));
    console.log(biggestNumber);
}