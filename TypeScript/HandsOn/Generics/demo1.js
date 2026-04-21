"use strict";
//generic functions
function getValue(value) {
    return value;
}
let num = getValue(10);
let str = getValue('Hello');
let result = getValue(100); //Type interecne(no need to pass type always)
let response = {
    data: 'Success',
    status: 200
};
//generic classes
class Box {
    value;
    constructor(value) {
        this.value = value;
    }
}
let box = new Box(100);
let box1 = new Box('100');
function pair(key, value) {
    return [key, value];
}
let p = pair('age', 24);
console.log(p[0] + ' ' + p[1]);
