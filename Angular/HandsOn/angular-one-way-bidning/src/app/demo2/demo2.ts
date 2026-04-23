import { Component } from '@angular/core';
import { Product } from '../product';
@Component({
  selector: 'app-demo2',
  imports: [],
  templateUrl: './demo2.html',
  styleUrl: './demo2.css',
})
export class Demo2 {
  //declare model
  product: Product | null = null;
  constructor() {
    //initiate model
    this.product = {
      productId: 93427,
      productName: 'Mouse',
      price: 500

    }
  }
}
