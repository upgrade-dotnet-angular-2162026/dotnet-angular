//Non-Prieitive/reference type
//arrays
let numbers: number[] = [1, 2, 3];
let names: Array<string> = ["A", "B"];
let flowers: string[] = ["Rose", 'Lilly'];
//tuple
let person: [string, number] = ["San", 25]
//enum
enum Status {
    Pending,
    Completed,
    Cancelled
}
let orderStatus: Status = Status.Completed
//any(diable the type checking)
let v: any = 'Hello'
console.log(`v:${v}`)
v = 456
console.log(`v:${v}`)
v = true
console.log(`v:${v}`)
//unknown
let value1: unknown = 'Hello'
value1 = 343;
//object
let user: object = { name: 'san', age: 34 };