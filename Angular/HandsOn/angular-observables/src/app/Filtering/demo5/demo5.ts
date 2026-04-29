import { Component } from '@angular/core';
import { of, filter } from 'rxjs';
@Component({
  selector: 'app-demo5',
  imports: [],
  templateUrl: './demo5.html',
  styleUrl: './demo5.css'
})
export class Demo5 {
  constructor() {
    // of → emit values in sequence
    // filter → filter the emitted values based on a condition
    of(1, 2, 3, 4, 5).pipe(
      filter(v => v % 2 === 0)
    ).subscribe(v => {
      console.log(v); // 2, 4
    }
    );
  }
}
