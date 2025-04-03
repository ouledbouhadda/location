import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-dashboard-proprietaire',
  standalone: true,
  imports: [CommonModule,RouterModule],
  templateUrl: './dashbord-proprietaire.component.html',
})
export class DashboardProprietaireComponent {}
