import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Info } from './info/info';
import { Details } from "./details/details";
@Component({
  selector: 'app-root',
  imports: [Info, Details, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('agnular-components');
}
