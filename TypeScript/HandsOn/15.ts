export { }
//Tuple Demo
let arrTuple = [100, 'TypeScript', 12.34, 'Abiram']
console.log(arrTuple)
let t1 = [100, 101]; //tuple with two elements
t1[0] = 100;
t1[1] = 101;
console.log(t1);
//access element in a tuple
console.log(t1[0]);
console.log(t1[1]);
//add value to tuple using push()
t1.push(123);
console.log(t1);
t1.pop(); //remove last value from tuple
console.log(t1);
let person: [string, number] = ["San", 24];
console.log(person[0]);
console.log(person[1]);
let employee: [string, number, boolean?]; //tuple with optional value
employee = ["Raj", 30];
employee = ["Raj", 30, true];
//named tuples
let user: [name: string, age: number]
user = ["Raj", 34];
console.log(user[0])
console.log(user[1]);
