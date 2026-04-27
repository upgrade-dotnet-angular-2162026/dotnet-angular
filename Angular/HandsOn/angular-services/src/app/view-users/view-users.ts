import { Component } from '@angular/core';
import { Data } from '../services/data';
@Component({
  selector: 'app-view-users',
  imports: [],
  templateUrl: './view-users.html',
  styleUrl: './view-users.css',
})
export class ViewUsers {
  users: string[] = [];
  constructor(private dataService: Data) { }
  ngOnInit() {
    this.users = this.dataService.getUsers();
  }
}
