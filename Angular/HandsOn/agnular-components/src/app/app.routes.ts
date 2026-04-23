import { Routes } from '@angular/router';
import { Info } from './info/info';
import { Details } from './details/details';
//router array
export const routes: Routes = [
    //define the routes here
    { path: 'home', component: Info },
    { path: 'details', component: Details },
    { path: '', component: Info }
];
