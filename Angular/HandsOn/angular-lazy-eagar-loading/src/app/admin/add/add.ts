import { Component } from '@angular/core';

@Component({
  selector: 'app-add',
  imports: [],
  templateUrl: './add.html',
  styleUrl: './add.css'
})
export class Add {
  constructor() {
    console.log('📦 AddComponent constructor called');
  }

  ngOnInit() {
    console.log('✅ AddComponent initialized');
  }
}
