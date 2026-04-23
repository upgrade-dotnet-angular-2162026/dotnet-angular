import { Component } from '@angular/core';
import { Product } from '../product';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-demo3',
  imports: [CommonModule],
  templateUrl: './demo3.html',
  styleUrl: './demo3.css',
})
export class Demo3 {
  products: Product[] = []; //empty array
  constructor() {
    this.products = [
      { productId: 33, productName: 'Mouse', price: 500 },
      { productId: 32, productName: 'Keyboard', price: 1500 },
      { productId: 31, productName: 'Bottle', price: 2500 },
      { productId: 38, productName: 'Pendrive', price: 3500 },
    ]
  }
}
