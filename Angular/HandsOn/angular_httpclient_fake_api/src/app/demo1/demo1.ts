import { Component, inject } from '@angular/core';
import { UserService } from '../user-service';
@Component({
  selector: 'app-demo1',
  imports: [],
  templateUrl: './demo1.html',
  styleUrl: './demo1.css',
})
export class Demo1 {
  users: any[] = [];
  //injecting service using DI
  private userService = inject(UserService);
  // constructor(private userService: UserService) {

  // }
  ngOnInit() {
    this.userService.getUsers().
      subscribe(response => {
        this.users = response;
        console.log(this.users);
      })
  }
}
