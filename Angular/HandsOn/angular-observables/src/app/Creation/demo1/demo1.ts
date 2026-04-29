import { Component } from '@angular/core';
import { of } from 'rxjs';
@Component({
  selector: 'app-demo1',
  imports: [],
  templateUrl: './demo1.html',
  styleUrl: './demo1.css'
})
export class Demo1 {
  x: number = 0;
  constructor() {
    // of → emit values in sequence
    of(1, 2, 3).subscribe(v => {
      this.x += v;
      console.log(this.x);

    });
  }
}
