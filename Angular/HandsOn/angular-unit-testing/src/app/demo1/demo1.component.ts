import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  public Greet():string
  {
    return 'Hello World';
  }
  public Note(name:string):string
  {
    return "Hi,"+name;
  }
  public GetFlowers():string[]
  {
    let flowers= ["Marigold","Rose","Lilly","Jasmine","Tulips"]
    return flowers;
  }
  public IsEven(no:number):boolean
  {
    return no%2==0?true:false;
  }

}
