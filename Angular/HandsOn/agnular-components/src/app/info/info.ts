import { Component } from '@angular/core';

@Component({
  selector: 'app-info',
  imports: [],
  templateUrl: './info.html',
  styleUrl: './info.css',
  // template: `<h2>Hello</h2>`,
  // styles:``
})
export class Info {
  name: string = 'Vikas';
  details(): void {
    this.name = 'Suraj';
  }
}
