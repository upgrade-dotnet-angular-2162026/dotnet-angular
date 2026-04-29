import { Component, OnInit } from '@angular/core';
import { UserObservableService } from '../user-observable-service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-user-list',
  imports: [CommonModule],
  templateUrl: './user-list.html',
  styleUrl: './user-list.css'
})
export class UserList {
  users: any[] = [];

  constructor(private userService: UserObservableService) { }

  ngOnInit() {
    this.userService.getUsers().subscribe(data => this.users = data);
  }
}
