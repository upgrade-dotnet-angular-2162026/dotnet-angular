class A {
}
class B {
}
let abobj;
class Car {
    drive() {
        console.log('drive the car');
        return this;
    }
    stop() {
        console.log('stop the car');
        return this;
    }
}
class Ferrai extends Car {
    speed(km) {
        console.log('speed up');
        return this;
    }
}
let carobj = new Ferrai();
carobj.drive().speed(300).stop();
