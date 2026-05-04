import { Routes } from '@angular/router';
import { Dashboard } from './dashboard/dashboard/dashboard';
import { Login } from './auth/login/login';
export const routes: Routes = [
    { path: '', component: Dashboard },     // Eager
    { path: 'login', component: Login },    // Eager

    // Lazy modules
    {
        path: 'admin',
        loadComponent: () => import('./admin/admin/admin').then(m => m.Admin), children: [
            { path: 'view-products', loadComponent: () => import('./admin/view-products/view-products').then(m => m.ViewProducts) },
            { path: 'add', loadComponent: () => import('./admin/add/add').then(m => m.Add) },
        ]
    },
    {
        path: 'reports',
        loadComponent: () => import('./reports/reports/reports').then(m => m.Reports)
    },

    { path: '**', redirectTo: '' } // Fallback
];
