//define interface
//define the structure of object
interface User {
    readonly id:number
    name: string;
    age: number;
    city?: string; //optional parameter
}
//initiate object to the interface
let user: User = {
    name: 'Virat',
    age: 23,
    id:332
}
user.name = 'Karan';
let user1: User = {
    name: 'Rohith',
    age: 34,
    city: 'Mumbai',
    id:345
}
//readonly props can not access using object to assign
//user1.id=432034; //not able to assign because its read-only