class Employee {
    name;
    constructor(name) {
        this.name = name;
    }
    greet() {
        console.log('Hello ' + this.name);
    }
}
let emp = new Employee('Virat');
emp.greet();
export {};
