import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-dashboard-client',
  standalone: true,
  imports: [CommonModule,RouterModule],
  templateUrl: './dashboard-client.component.html',
})
export class DashboardClientComponent {}
