import { Routes } from '@angular/router';
import { Login } from './login/login';
import { AdminDashboard } from './Admin/admin-dashboard/admin-dashboard';
import { UserDashboard } from './User/user-dashboard/user-dashboard';
import { ViewProducts } from './Admin/view-products/view-products';
import { AddProduct } from './Admin/add-product/add-product';
import { authGuard } from './auth-guard';
export const routes: Routes = [
    { path: 'login', component: Login },
    { path: '', redirectTo: 'login', pathMatch: 'full' },
    {
        path: 'admin-dashboard', component: AdminDashboard, children: [
            { path: 'view-products', component: ViewProducts },
            { path: 'add-product', component: AddProduct }
        ], canActivate: [authGuard]
    },
    { path: 'user-dashboard', component: UserDashboard }
];
