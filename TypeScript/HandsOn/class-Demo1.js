class Student {
    //varialbe
    sId;
    sName;
    //method
    show() {
        console.log(`Id:${this.sId} Name:${this.sName}`);
    }
}
//create object
let student = new Student(); //javascript style
//access class members using object
student.sId = 1;
student.sName = 'Rohan';
student.show();
let stu = new Student(); //typescript style
stu.sId = 2;
stu.sName = 'Karan';
stu.show();
let a = 10; //default type is any
let n = 10;
export {};
