import { Component } from '@angular/core';
import { of, map } from 'rxjs';
@Component({
  selector: 'app-demo3',
  imports: [],
  templateUrl: './demo3.html',
  styleUrl: './demo3.css'
})
export class Demo3 {
  constructor() {
    // of → emit values in sequence
    // map → transform the emitted values
    of(1, 2, 3).pipe(
      map(v => v * 10)
    ).subscribe(v => {
      console.log(v); // 10, 20, 30
    }
    )
  };
}