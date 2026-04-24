import { Component } from '@angular/core';

@Component({
  selector: 'app-demo5',
  imports: [],
  templateUrl: './demo5.html',
  styleUrl: './demo5.css',
})
export class Demo5 {
  count = 0;
  value: string = '';
  name: string = 'Virat';
  increment() {
    this.count++;
  }
  greet(name: string) {
    alert(`Hello ${name}`)
  }
  getValue(event: any) {
    this.value = event.target.value;
    console.log(this.value);
  }
}
