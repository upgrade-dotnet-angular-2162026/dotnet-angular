import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  imports: [],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css'
})
export class Dashboard {
  constructor() {
    console.log('📦 DashboardComponent constructor called');
  }

  ngOnInit() {
    console.log('✅ DashboardComponent initialized');
  }
}
