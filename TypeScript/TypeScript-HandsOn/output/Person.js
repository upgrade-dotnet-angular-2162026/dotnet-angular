import { PI } from './IPerson';
class Person {
    constructor(pid, pname) {
        console.log('PI=' + PI);
        if (pid == null) {
            console.log('Default constructor');
        }
        else if (pname == null) {
            console.log('1 Parameterized constructor');
        }
        else {
            console.log('2 Parameterized constructor');
            this.PersonId = pid;
            this.PersonName = pname;
        }
    }
    getDetails(code, a, b) {
        if (a == null) {
            console.log('1nd function');
        }
        else if (b == null) {
            console.log('2rd function');
        }
        else {
            console.log('3rd function');
        }
        console.log("Id=" + this.PersonId);
        console.log(`Name=${this.PersonName}`);
    }
    getData() {
    }
}
class Employee extends Person {
    constructor(EmpCode) {
        super(1, 'test');
        this.EmpCode = EmpCode;
    }
}
let emp = new Employee("E001");
emp.EmpCode = "E001";
let personObj = new Person(1, 'pradeep');
personObj.getDetails('test');
