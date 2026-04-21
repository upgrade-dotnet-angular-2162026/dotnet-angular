"use strict";
class Calculate {
    Add(a, b) {
        return a + b;
    }
    Greet(name) {
        return 'Hello ' + name;
    }
    GetFlowers() {
        return ["Rose", "Lilly", "Tulips"];
    }
}
let calc = new Calculate();
console.log(calc.Add(12, 23));
console.log(calc.GetFlowers());
console.log(calc.Greet('Sachin'));
