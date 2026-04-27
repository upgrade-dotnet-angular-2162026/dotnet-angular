import { Routes } from '@angular/router';
import { User } from './user/user';
import { ViewUsers } from './view-users/view-users';

export const routes: Routes = [
    { path: 'user', component: User },
    { path: 'view', component: ViewUsers }
];
