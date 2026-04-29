import { Component } from '@angular/core';
import { from, pluck } from 'rxjs';
@Component({
  selector: 'app-demo4',
  imports: [],
  templateUrl: './demo4.html',
  styleUrl: './demo4.css'
})
export class Demo4 {
  constructor() {
    // from → convert array/promise into Observable
    // pluck → select a property from the emitted objects
    from([
      { id: 1, name: 'Angular' },
      { id: 2, name: 'RxJS' }
    ]).pipe(
      pluck('name')
    ).subscribe(console.log);
    // Output: Angular, RxJS
  }
}
