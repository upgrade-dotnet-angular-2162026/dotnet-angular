import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class UserObservableService {
  getUsers(): Observable<any[]> {
    return of([
      { id: 1, name: 'John Doe' },
      { id: 2, name: 'Alice' }
    ]);
  }
}
