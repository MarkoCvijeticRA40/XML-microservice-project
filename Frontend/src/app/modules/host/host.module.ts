import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { MatTableModule } from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MaterialModule } from 'src/app/material/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ErrorStateMatcher, MatNativeDateModule, ShowOnDirtyErrorStateMatcher } from '@angular/material/core';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatRadioModule } from '@angular/material/radio';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatDialogModule } from '@angular/material/dialog';
import { HostComponent } from './host/host.component';
import { ProfileComponent } from '../pages/profile/profile.component';
import { ApproveReservationComponent } from './approve-reservation/approve-reservation.component';
import { CreateAccommodationComponent } from './create-accommodation/create-accommodation.component';
import { HostAccommodationsComponent } from './host-accommodations/host-accommodations.component';
import { ChangeDateAccommodationComponent } from './change-date-accommodation/change-date-accommodation.component';
import { ChangePriceAccommodationComponent } from './change-price-accommodation/change-price-accommodation.component';


const routes: Routes = [
  {
    path: '', component: HostComponent, children: [
      { path: 'approve/reservation', component:  ApproveReservationComponent },
      { path: 'hostAccommodations', component: HostAccommodationsComponent },
      { path: 'createAccommodation', component: CreateAccommodationComponent },
      { path: 'profil', component: ProfileComponent },


    ]
  }
];

@NgModule({
  declarations: [
    HostComponent,
    ApproveReservationComponent,
    CreateAccommodationComponent,
    HostAccommodationsComponent,
    ChangeDateAccommodationComponent,
    ChangePriceAccommodationComponent,
    ],
  imports: [
    CommonModule,
    MatTableModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MaterialModule,
    ReactiveFormsModule,
    FormsModule,
    MatNativeDateModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatRadioModule,
    MatDatepickerModule,
    MatToolbarModule,
    MatDialogModule,
    RouterModule.forChild(routes)
  ],
   exports: [ RouterModule ]
})
export class HostModule { }
