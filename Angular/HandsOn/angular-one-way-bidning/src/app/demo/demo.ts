import { Component } from '@angular/core';

@Component({
  selector: 'app-demo',
  imports: [],
  templateUrl: './demo.html',
  styleUrl: './demo.css',
})
export class Demo {
  title: string = 'One Way DataBinindg Demo using string Interpolation';
  userName: string = 'John';
  age:number=23;
}
