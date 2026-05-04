import { Component } from '@angular/core';

@Component({
  selector: 'app-reports',
  imports: [],
  templateUrl: './reports.html',
  styleUrl: './reports.css'
})
export class Reports {
constructor() {
    console.log('📦 ReportsComponent constructor called');
  }

  ngOnInit() {
    console.log('✅ ReportsComponent initialized');
  }
}
