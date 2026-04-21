"use strict";
class Employee {
    //variable
    eId;
    eName;
    jDate;
    salary;
    desig;
    //constructor
    constructor(eId, eName, jDate, salary, desig) {
        this.eId = eId;
        this.eName = eName;
        this.jDate = jDate;
        this.salary = salary;
        this.desig = desig;
    }
    //method
    show() {
        console.log(`ID:${this.eId} Name:${this.eName} JoinDate:${this.jDate}
         Salary:${this.salary} Designation:${this.desig}`);
    }
}
let emp = new Employee(100, 'Rohan', new Date(2021, 2, 20), 23000, 'Programmer');
emp.show();
//array of objects
let employees = [
    new Employee(100, 'Rohan', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(101, 'Karan', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(102, 'Charan', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(103, 'Jeson', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(104, 'Monica', new Date(2018, 2, 20), 23000, 'TeamLead'),
    new Employee(105, 'Tim', new Date(2021, 2, 20), 23000, 'Programmer'),
];
for (let item of employees) {
    item.show();
}
