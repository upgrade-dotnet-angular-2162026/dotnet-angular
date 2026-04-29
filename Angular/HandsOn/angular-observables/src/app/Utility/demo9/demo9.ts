import { Component } from '@angular/core';
import { of, map, tap, delay } from 'rxjs';
@Component({
  selector: 'app-demo9',
  imports: [],
  templateUrl: './demo9.html',
  styleUrl: './demo9.css'
})
export class Demo9 {
  constructor() {
    //tap → perform side-effects (logging, debugging)
    of(5, 10).pipe(
      tap(val => console.log('Before:', val)),
      map(val => val * 2),
      tap(val => console.log('After:', val))
    ).subscribe();
    // Output: Before: 5, After: 10, Before: 10, After: 20

    //delay → delay emissions
    of('Hello Angular').pipe(
      delay(2000)
    ).subscribe(console.log);
    // Output after 2 seconds: Hello Angular
  }
}
