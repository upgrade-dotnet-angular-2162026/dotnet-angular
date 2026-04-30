import { Component, inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ChangeDetectorRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-view-products',
  imports: [CommonModule],
  templateUrl: './view-products.html',
  styleUrl: './view-products.css',
})
export class ViewProducts {
  private http = inject(HttpClient);
  private cd = inject(ChangeDetectorRef);
  private router = inject(Router);
  data: any[] = [];
  ngOnInit() {
    if (localStorage.getItem('token')) {
      const token = localStorage.getItem('token');
      console.log(token);
      const headers = new HttpHeaders({
        'Authorization': `Bearer ${token}`
      });
      this.http.get<any[]>('http://localhost:5034/product-service/',
        { headers }
      ).subscribe(response => {
        this.data = response
        console.log(this.data);
        this.cd.detectChanges();
      })
    }
    else {
      this.router.navigateByUrl('/login');
    }

  }
}
