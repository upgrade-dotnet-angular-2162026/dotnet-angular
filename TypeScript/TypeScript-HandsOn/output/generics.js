class Queue {
    constructor() {
        this.lst = [];
    }
    insert(item) {
        this.lst.push(item);
    }
    remove() {
        this.lst.shift();
    }
    display() {
        for (let l of this.lst) {
            console.log(l);
        }
    }
}
let obj = new Queue();
obj.insert(1);
obj.insert(3);
obj.insert(5);
obj.insert(6);
obj.remove();
obj.remove();
obj.display();
