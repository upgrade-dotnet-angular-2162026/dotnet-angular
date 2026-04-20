//intersction
class A
{
    id: string;
}

class B
{
    name: string;
}

let abobj: A&B;

//declaration merging
interface ICar{
    drive();
}

interface ICar{
    stop();
}

//polymorphic this type
//it represents a type that is a sub type of containing class/interface
//it helps to create fluent api

class Car
{
    drive(): this
    {
        console.log('drive the car');
        return this;
    }

    stop(): this
    {
        console.log('stop the car');
        return this;
    }
}

class Ferrai extends Car
{
     speed(km: number): this
     {
            console.log('speed up');
            return this;
     }
}

let carobj = new Ferrai();
carobj.drive().speed(300).stop();

