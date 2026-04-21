"use strict";
class Car {
    color;
    constructor(color) {
        this.color = color;
    }
}
class Benz extends Car {
    cost;
    constructor(color, cost) {
        super(color); //invoke Car Construcotr
        this.cost = cost;
    }
    show() {
        console.log("Color of the Benz Car " + this.color);
        console.log("Price of the Car " + this.cost);
    }
}
let obj = new Benz('Black', 78000000);
obj.show();
