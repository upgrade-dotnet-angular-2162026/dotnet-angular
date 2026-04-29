import { Component, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ProductCreate } from '../../Models/product-create';
@Component({
  selector: 'app-add',
  imports: [FormsModule],
  templateUrl: './add.html',
  styleUrl: './add.css',
})
export class Add {
  product: ProductCreate = {
    name: '',
    price: 0,
    stock: 0
  };
  private http = inject(HttpClient);
  res: any;
  add() {
    console.log(this.product);
    this.http.post('http://localhost:5156/api/Product/Add', this.product).subscribe((response) => {
      console.log(response);
    }, (err) => console.log(err));
  }
}
