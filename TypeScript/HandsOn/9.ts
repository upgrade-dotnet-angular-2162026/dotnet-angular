export { }
//arrays
let n: string[] = ['Rohan', 'Charan', 'Sunil', 'Dev'] //array of strings
//assing value to array
n[4] = 'Karan'
//access a value
console.log(n[0])
console.log(n[8]) //undefined
//fetch array values using for loop
for (let k = 0; k < n.length; k++) {
    console.log(n[k])
}
let number: number[] = [12, 34, 56, 78, 90]; //array of numbers