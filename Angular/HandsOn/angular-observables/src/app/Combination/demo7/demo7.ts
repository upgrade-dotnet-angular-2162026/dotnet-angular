import { Component } from '@angular/core';
import { of, merge } from 'rxjs';
@Component({
  selector: 'app-demo7',
  imports: [],
  templateUrl: './demo7.html',

})
export class Demo7 {
  constructor() {
    // of → emit values in sequence
    // merge → combine multiple Observables into one
    merge(
      of(1, 2, 3),
      of(4, 5, 6),
      of(7, 8, 9)
    ).subscribe(v => {
      console.log(v); // 1, 4, 7, 2, 5, 8, 3, 6, 9
    }
    );
  };
}
