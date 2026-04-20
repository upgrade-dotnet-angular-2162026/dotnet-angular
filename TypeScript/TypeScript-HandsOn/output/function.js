function add(x, y) {
    return x + y;
}
var result1 = add(10, 20.4);
console.log(result1);
var result2 = function (x, y) {
    return x + y;
};
console.log(result2(1, 2));
var result3 = (x, y) => {
    return x + y;
};
console.log(result3(1, 2));
