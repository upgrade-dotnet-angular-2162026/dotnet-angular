import { Component, inject } from '@angular/core';
import { RouterOutlet, RouterLinkWithHref, Router } from '@angular/router';

@Component({
  selector: 'app-admin-dashboard',
  imports: [RouterOutlet, RouterLinkWithHref],
  templateUrl: './admin-dashboard.html',
  styleUrl: './admin-dashboard.css',
})
export class AdminDashboard {
  private router = inject(Router);
  logOut() {
    localStorage.clear(); //clear the local storage data
    this.router.navigateByUrl('/login');

  }
}
