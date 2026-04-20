//named
function add(x: number, y:number): number{

    return x + y;
}

var result1 = add(10,20.4);
console.log(result1);

//anonymous
var result2 = function(x:number,y:number):number{
    return x+y;
}
console.log(result2(1,2));

//arrow
var result3 = (x:number, y: number):number => {
    return x+y;
}
console.log(result3(1,2));