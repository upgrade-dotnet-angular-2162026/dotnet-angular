import { Component, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-demo1',
  imports: [],
  templateUrl: './demo1.html',
  styleUrl: './demo1.css',
})
export class Demo1 {
  title = 'Angular Debug';
  name?: string;
  price: number = 100;
  private http = inject(HttpClient);
  ngOnInit() {
    console.log("Component initialized");
    console.warn("This is a warning: Data might be null");
    console.error("This is an error: API failed");
    this.loadUsers();

  }
  loadUsers() {
    this.http.get('/api/users').subscribe({
      next: (res) => {
        console.log("Users loaded successfully", res);
      },
      error: (err) => {
        console.error("API Error occurred", err);

        if (err.status === 404) {
          console.warn("Users not found (404)");
        }
      }
    });
  }
}
