import { Component } from '@angular/core';
import { User } from '../user';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-login',
  imports: [FormsModule, CommonModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  users: User[] = [];
  user: User = {};
  message: string = '';
  constructor() {
    this.users = [
      { username: 'rohan', password: '12345' },
      { username: 'pavan', password: '12345' },
      { username: 'swathi', password: '12345' },
      { username: 'teja', password: '12345' },
    ]
  }
  validate() {
    console.log(this.user);
    let user = this.users.find(u => u.username == this.user?.username && u.password == this.user?.password)
    if (user != null) {
      this.message = "Valid User";
    }
    else {
      this.message = "InValid User"
    }
  }
}
