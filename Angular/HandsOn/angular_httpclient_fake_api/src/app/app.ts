import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ViewUsres } from "./view-usres/view-usres";
import { Demo1 } from "./demo1/demo1";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, ViewUsres, Demo1],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular_httpclient_fake_api');
}
