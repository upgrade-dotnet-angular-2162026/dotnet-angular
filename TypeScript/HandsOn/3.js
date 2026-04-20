"use strict";
//Non-Prieitive/reference type
//arrays
let numbers = [1, 2, 3];
let names = ["A", "B"];
let flowers = ["Rose", 'Lilly'];
//tuple
let person = ["San", 25];
//enum
var Status;
(function (Status) {
    Status[Status["Pending"] = 0] = "Pending";
    Status[Status["Completed"] = 1] = "Completed";
    Status[Status["Cancelled"] = 2] = "Cancelled";
})(Status || (Status = {}));
let orderStatus = Status.Completed;
//any(diable the type checking)
let v = 'Hello';
console.log(`v:${v}`);
v = 456;
console.log(`v:${v}`);
v = true;
console.log(`v:${v}`);
//unknown
let value1 = 'Hello';
value1 = 343;
//object
let user = { name: 'san', age: 34 };
