import { Component, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { ProductRead } from '../../Models/product-read';
import { ChangeDetectorRef } from '@angular/core';
@Component({
  selector: 'app-view-all',
  imports: [CommonModule],
  templateUrl: './view-all.html',
  styleUrl: './view-all.css',
})
export class ViewAll {
  products: ProductRead[] = [];
  //initiate HttpClient using DI
  private http = inject(HttpClient);
  private cd = inject(ChangeDetectorRef);
  ngOnInit() {
    this.http.get<ProductRead[]>('http://localhost:5156/api/Product/GetAll').subscribe(response => {
      this.products = response
      console.log(this.products);
      this.cd.detectChanges(); //force reload
    }, error => {
      console.log(error)
    })
  }
}
