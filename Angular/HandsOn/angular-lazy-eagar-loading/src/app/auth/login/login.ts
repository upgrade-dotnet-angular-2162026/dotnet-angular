import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  imports: [],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
constructor() {
    console.log('📦 LoginComponent constructor called');
  }

  ngOnInit() {
    console.log('✅ LoginComponent initialized');
  }
}
