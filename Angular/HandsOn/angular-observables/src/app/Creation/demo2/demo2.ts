import { Component } from '@angular/core';
import { from } from 'rxjs';
@Component({
  selector: 'app-demo2',
  imports: [],
  templateUrl: './demo2.html',
  styleUrl: './demo2.css'
})
export class Demo2 {
  //from → convert array/promise into Observable
  x: number = 0;
  constructor() {
    from([1, 2, 3]).subscribe(v => {
      this.x += v;
      console.log(this.x);
    });
  }
}
