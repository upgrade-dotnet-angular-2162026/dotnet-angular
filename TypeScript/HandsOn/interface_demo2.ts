export { }
interface A {
    a: string;
}
interface B {
    b: number;
}
interface C extends A, B {

}
let obj: C = {
    a: '10', b: 20
}