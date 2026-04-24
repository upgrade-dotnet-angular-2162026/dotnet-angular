import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-demo2',
  imports: [CommonModule, FormsModule],
  templateUrl: './demo2.html',
  styleUrl: './demo2.css',
})
export class Demo2 {
  cities: string[] = ['Chennai', 'Hyderabad']
  city: string = '';
  addCity() {
    //add item to the array
    console.log(this.city);
    this.cities.push(this.city);
    console.log(this.cities);
    this.city = '';
  }
}
