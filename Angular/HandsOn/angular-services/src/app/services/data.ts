import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class Data {
  private users = ['Pavan', 'Teja', 'Vishunu'];
  getUsers() {
    return this.users;
  }
  addUser(name: string) {
    this.users.push(name);
  }
}
