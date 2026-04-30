import { Routes } from '@angular/router';
import { Login } from './login/login';
import { AdminDashboard } from './Admin/admin-dashboard/admin-dashboard';
import { UserDashboard } from './User/user-dashboard/user-dashboard';

export const routes: Routes = [
    { path: 'login', component: Login },
    { path: '', redirectTo: 'login', pathMatch: 'full' },
    { path: 'admin-dashboard', component: AdminDashboard },
    { path: 'user-dashboard', component: UserDashboard }
];
