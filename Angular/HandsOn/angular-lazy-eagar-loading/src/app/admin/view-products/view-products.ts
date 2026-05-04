import { Component } from '@angular/core';

@Component({
  selector: 'app-view-products',
  imports: [],
  templateUrl: './view-products.html',
  styleUrl: './view-products.css'
})
export class ViewProducts {
  constructor() {
    console.log('📦 ViewProductsComponent constructor called');
  }

  ngOnInit() {
    console.log('✅ ViewProductsComponent initialized');
  }
}
