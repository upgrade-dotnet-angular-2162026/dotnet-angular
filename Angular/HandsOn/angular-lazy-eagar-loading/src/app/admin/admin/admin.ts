import { Component } from '@angular/core';
import { RouterOutlet,RouterLink } from '@angular/router';
@Component({
  selector: 'app-admin',
  imports: [RouterOutlet,RouterLink],
  templateUrl: './admin.html',
  styleUrl: './admin.css'
})
export class Admin {
  constructor() {
    console.log('📦 AdminComponent constructor called');
  }

  ngOnInit() {
    console.log('✅ AdminComponent initialized');
  }
}
