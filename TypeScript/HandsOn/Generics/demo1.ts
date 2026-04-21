//generic functions
function getValue<T>(value: T): T {
    return value;
}
let num = getValue<number>(10);
let str = getValue<string>('Hello');
let result = getValue(100); //Type interecne(no need to pass type always)
//generic interfaces
interface ApiResponse<T> {
    data: T;
    status: number
}
let response: ApiResponse<string> = {
    data: 'Success',
    status: 200
};
//generic classes
class Box<T> {
    value: T;
    constructor(value: T) {
        this.value = value;
    }
}
let box = new Box<number>(100);
let box1 = new Box<string>('100');
//generic with multiple identifiers
function pair<K, V>(key: K, value: V): [K, V] {
    return [key, value];
}
let p = pair<string, number>('age', 24);
console.log(p[0] + ' ' + p[1]);