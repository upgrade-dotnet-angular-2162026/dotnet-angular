import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'app-view-usres',
  imports: [CommonModule],
  templateUrl: './view-usres.html',
  styleUrl: './view-usres.css',
})
export class ViewUsres {
  users: any[] = [];
  constructor(private cd: ChangeDetectorRef, private http: HttpClient) { }
  ngOnInit() {

    this.http.get<any>
      ('https://jsonplaceholder.typicode.com/users')
      .subscribe(data => {
        this.users = data
        this.cd.detectChanges(); //force update
        console.log(this.users);
      })
  }
}
