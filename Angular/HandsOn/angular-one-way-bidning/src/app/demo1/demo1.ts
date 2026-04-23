import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-demo1',
  imports: [CommonModule],
  templateUrl: './demo1.html',
  styleUrl: './demo1.css',
})
export class Demo1 {
  cities: string[] = ['Pune', 'Hyd', 
    'Chennai', 'Banglore']
    numbers:number[]=[12,23,34,45]
}
