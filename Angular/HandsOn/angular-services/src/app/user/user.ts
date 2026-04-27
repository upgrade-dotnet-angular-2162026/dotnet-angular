import { Component } from '@angular/core';
import { Data } from '../services/data';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-user',
  imports: [FormsModule],
  templateUrl: './user.html',
  styleUrl: './user.css',
})
export class User {
  users: string[] = [];
  newUser: string = '';
  constructor(private dataService: Data) { }
  ngOnInit() {
    this.users = this.dataService.getUsers();
    console.log(this.users);
  }
  addUser() {
    this.dataService.addUser(this.newUser);
    this.newUser = '';
  }
}
