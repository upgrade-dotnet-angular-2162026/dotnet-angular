import { Routes } from '@angular/router';
import { Demo } from './demo/demo';
import { Demo1 } from './demo1/demo1';
import { Demo3 } from './demo3/demo3';

export const routes: Routes = [
    {
        path: 'demo', component: Demo
    },
    { path: 'demo1', component: Demo1 },
    { path: 'demo3', component: Demo3 }
];
