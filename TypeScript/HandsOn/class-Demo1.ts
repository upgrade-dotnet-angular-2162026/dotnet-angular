export {}
class Student
{
    //varialbe
    public sId?:number;
    public sName?:string;
    //method
    show(): void {
        console.log(`Id:${this.sId} Name:${this.sName}`)
    }
}
//create object
let student=new Student(); //javascript style
//access class members using object
student.sId=1;
student.sName='Rohan';
student.show();
let stu:Student=new Student(); //typescript style
stu.sId=2;
stu.sName='Karan';
stu.show()
let a=10; //default type is any
let n:number=10;