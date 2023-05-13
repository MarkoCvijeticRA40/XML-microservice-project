import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { RoleGuardService } from "./service/role-guard.service";

const routes: Routes = [
  {
    path: 'pages',
    loadChildren: () => import('./modules/pages/pages.module').then(m => m.PagesModule),
  },
  {
    path: 'guest',
    loadChildren: () => import('./modules/guest/guest.module').then(m => m.GuestModule),
    //canActivate:[RoleGuardService], data : {expectedRole : 'Admin'}
  },
  {
    path: 'host',
    loadChildren: () => import('./modules/host/host.module').then(m => m.HostModule),
    //canActivate:[RoleGuardService], data : {expectedRole : 'Host'}
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
