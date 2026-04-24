import { Routes } from '@angular/router';
import { Demo1 } from './demo1/demo1';
import { Demo2 } from './demo2/demo2';
import { Demo3 } from './demo3/demo3';
import { Login } from './login/login';

export const routes: Routes = [
    { path: 'demo1', component: Demo1 },
    { path: 'demo2', component: Demo2 },
    { path: 'demo3', component: Demo3 },
    { path: 'login', component: Login },
    { path: '', component: Login } //set default path to login
];
