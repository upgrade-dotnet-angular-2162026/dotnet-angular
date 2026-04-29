import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-flight-list',
  imports: [],
  templateUrl: './flight-list.html',
  styleUrl: './flight-list.css'
})
export class FlightList implements OnInit {
  flights: any[] = [];
  constructor(private http: HttpClient) { }
  ngOnInit() {
    this.getFlights().subscribe({
      next: (data) => this.flights = data,
      error: (err) => console.error('Error:', err),
      complete: () => console.log('Data stream completed')
    });
    console.log(this.flights);// This will print the fetched data in the console
  }
  getFlights(): Observable<any[]> {
    return this.http.get<any[]>('http://localhost:5184/api/Flight/GetAllFlights');
  }

}
