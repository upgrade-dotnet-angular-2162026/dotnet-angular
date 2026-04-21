"use strict";
class Customer {
    //private variables
    cId;
    cname;
    constructor() {
        this.cId = 1000;
        this.cname = 'Jeson';
    }
    show() {
        console.log(`ID:${this.cId} Name:${this.cname}`);
    }
}
let customer = new Customer(); //customer object
customer.show();
