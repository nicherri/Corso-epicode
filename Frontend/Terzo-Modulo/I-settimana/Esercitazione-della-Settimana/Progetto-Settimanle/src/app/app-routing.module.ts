import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Pagina404Component } from './componentes/pagina404/pagina404.component';
import { FordComponent } from './componentes/ford/ford.component';
import { FiatComponent } from './componentes/fiat/fiat.component';
import { AudiComponent } from './componentes/audi/audi.component';
import { HomeComponent } from './componentes/home/home.component';

const routes: Routes = [
  {
    path:'',
    component: HomeComponent

  },
  {
    path:'Audi',
    title:'Audi',
    component: AudiComponent

  },
  {
    path:'Fiat',
    title:'Fiat',
    component: FiatComponent

  },
  {
    path:'Ford',
    title:'Ford',
    component: FordComponent

  },
  {
    path:'**',//pagina404
    title:'Erore 404',
    component: Pagina404Component

  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
