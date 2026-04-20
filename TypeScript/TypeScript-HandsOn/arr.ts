let arr: number[] = [1,2,3,4];

for(let a of arr)
{
    console.log(a);
}

for(let index=0;index< arr.length;index++)
{
    console.log(arr[index]);
}

for(let indx in arr)
{
    console.log(arr[indx]);
}

//union type
function calculate(x:number|string|boolean): number|string|boolean{
    
    if(typeof(x) == 'string')
    {
       return 'str'; 
    }
    if(typeof(x) == 'number')
    {
        return 0;
    }
    return false;
}

//destructuring
let chars: string[] = ['aa','bb','cc','dd'];
let [a1,b1,...rest] = chars; //...spread operator

console.log(a1);
console.log(b1);
for(let r of rest)
{
    console.log(r);
}

var books = [{ bname: 'abc', code: 'b1' }, { bname:'def', code: 'b2'} , { bname:'def', code: 'b2' }];
var [book1,book2,...remainingBooks]  = books;
console.log(book1.bname);
console.log(book2.bname);