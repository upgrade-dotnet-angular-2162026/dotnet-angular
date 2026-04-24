import { Component } from '@angular/core';

@Component({
  selector: 'app-demo4',
  imports: [],
  templateUrl: './demo4.html',
  styleUrl: './demo4.css',
})
export class Demo4 {
  title: string = 'Property Binding Demo';
  isDisabled: boolean = false;
  imgsrc: string = 'download.jfif';
  width: number = 150;
  height: number = 100;
  name:string="Virat";
  textColor='blue';
}
