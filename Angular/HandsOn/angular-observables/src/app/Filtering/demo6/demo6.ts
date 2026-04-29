import { Component } from '@angular/core';
import { of, take } from 'rxjs';
@Component({
  selector: 'app-demo6',
  imports: [],
  templateUrl: './demo6.html',
  styleUrl: './demo6.css'
})
export class Demo6 {
  constructor() {
    // of → emit values in sequence
    // take → take only the first n emitted values
    of(1, 2, 3, 4, 5).pipe(
      take(3)
    ).subscribe(v => {
      console.log(v); // 1, 2, 3
    }
    );
  };
}