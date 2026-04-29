import { Component } from '@angular/core';
import { of, concat } from 'rxjs';
@Component({
  selector: 'app-demo8',
  imports: [],
  templateUrl: './demo8.html',
  styleUrl: './demo8.css'
})
export class Demo8 {
  constructor() {
    // concat → emit values from multiple Observables, one after the other
    concat(
      of('First', 'Middle', 'Last'),
      of('Second', 'Third', 'Fourth')
    ).subscribe(v => {
      console.log(v); // 1, 2, 3, 4, 5, 6, 7, 8, 9
    }
    );
  }
}