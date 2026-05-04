import { Component, signal } from '@angular/core';
import { RouterOutlet, RouterLink } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular-lazy-eagar-loading');
  constructor() {
    console.log('📦 AppComponent constructor called');
  }

  ngOnInit() {
    console.log('✅ AppComponent initialized');
  }
}
