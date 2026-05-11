import { Component, inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-add-product',
  imports: [FormsModule],
  templateUrl: './add-product.html',
  styleUrl: './add-product.css',
})
export class AddProduct {
  private http = inject(HttpClient);
  name: string = '';
  price: number = 0;
  add() {
    const item = {
      name: this.name,
      price: this.price
    }
    console.log(item);
    const token = localStorage.getItem('token');
    const headers = new HttpHeaders({
      'Authorization': `Bearer ${token}`
    });
    this.http.post('http://localhost:5034/product-service/', item, { headers }).subscribe(response => {
      console.log(response);
    })
  }
}
