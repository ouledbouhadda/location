import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignupComponent } from './signup/signup.component';
import { LoginComponent } from './login/login.component';
import { DashboardProprietaireComponent } from './dashbordProprietaire/dashbord-proprietaire.component';
import { DashboardClientComponent } from './dashbordClient/dashbord-client.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SignupComponent },
  { path: 'dashboard-client', component: DashboardClientComponent },
  { path: 'dashboard-proprietaire', component: DashboardProprietaireComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
