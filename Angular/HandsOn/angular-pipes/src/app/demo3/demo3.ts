import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { GenderPipe } from '../gender-pipe';
@Component({
  selector: 'app-demo3',
  imports: [CommonModule, GenderPipe],
  templateUrl: './demo3.html',
  styleUrl: './demo3.css'
})
export class Demo3 {
  persons: any[] = [
    { name: 'Rohan', gender: 'male' },
    { name: 'Kavya', gender: 'female' },
    { name: 'Vikas', gender: 'male' }
  ];
}
