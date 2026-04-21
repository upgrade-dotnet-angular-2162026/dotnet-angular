export { }
//interface with class
interface Person {
    name: string;
    greet(): void;
}
class Employee implements Person {
    name: string;
    constructor(name: string) {
        this.name = name;
    }
    greet(): void {
        console.log('Hello ' + this.name);
    }
}
let emp: Employee = new Employee('Virat');
emp.greet();