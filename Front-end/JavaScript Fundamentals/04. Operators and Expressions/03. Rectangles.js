function solve(args) {
    let width = parseFloat(args[0]);
    let height = parseFloat(args[1]);
    let area = width*height;
    let perimeter =2* width+2*height;
    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}