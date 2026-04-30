import { Component, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ChangeDetectorRef } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  private http = inject(HttpClient);
  private router = inject(Router)
  email: string = '';
  password: string = ''
  response: any;
  errMsg: string = '';
  private cd = inject(ChangeDetectorRef);
  validate() {
    let user = {
      email: this.email,
      password: this.password
    }
    this.http.post('http://localhost:5034/user-service/validate', user).subscribe(data => {
      this.response = data;
      console.log(this.response);
      console.log(this.response.token);
      if (this.response.token != '') {
        let role = this.response.role;
        let token = this.response.token;
        //add token to the locastorage
        localStorage.setItem('token', token);
        if (role == 'Admin') {
          this.router.navigateByUrl('/admin-dashboard');
        }
        else if (role == 'User') {
          this.router.navigateByUrl('/user-dashboard');
        }
      }
      else {
        this.errMsg = "Invalid User Credentials";
      }
      this.cd.detectChanges();
    })

  }
}
