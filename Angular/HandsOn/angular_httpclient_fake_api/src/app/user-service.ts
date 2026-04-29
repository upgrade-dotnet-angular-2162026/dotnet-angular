import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  //private http=inject(HttpClient); Initiate object using DI
  constructor(private http: HttpClient) {

  }
  getUsers(): Observable<any> {
    return this.http.
    get('https://jsonplaceholder.typicode.com/users');
  }
}
