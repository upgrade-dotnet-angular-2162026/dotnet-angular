import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FlightList } from "./flight-list/flight-list";
import { UserList } from "./user-list/user-list";
import { Demo1 } from './Creation/demo1/demo1';
import { Demo2 } from "./Creation/demo2/demo2";
import { Demo3 } from './Transformation/demo3/demo3';
import { Demo4 } from "./Transformation/demo4/demo4";
import { Demo5 } from "./Filtering/demo5/demo5";
import { Demo6 } from "./Filtering/demo6/demo6";
import { Demo7 } from "./Combination/demo7/demo7";
import { Demo8 } from "./Combination/demo8/demo8";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, FlightList, UserList, Demo1, Demo2, Demo3, Demo4, Demo5, Demo6, Demo7, Demo8],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular-observables');
}
