class Queue<Titem>
{
    private lst: Array<Titem>;
    constructor()
    {
        this.lst = [];
    }

    insert(item: Titem){
        this.lst.push(item); //1,2,3
    }

    remove(){
        this.lst.shift();
    }

    display()
    {
        for(let l of this.lst)
        {
             console.log(l);
        }
    }
}

let obj = new Queue<number>();
obj.insert(1);
obj.insert(3);
obj.insert(5);
obj.insert(6);

obj.remove();
obj.remove();

obj.display();
