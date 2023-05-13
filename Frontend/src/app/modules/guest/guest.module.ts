import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GuestComponent } from './guest/guest.component';
import { ReservationsComponent } from './reservations/reservations.component';
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
import { ReserveAccommodationComponent } from './reserve-accommodation/reserve-accommodation.component';
import { ProfileComponent } from '../pages/profile/profile.component';
import { AccommodationComponent } from '../pages/accommodation/accommodation.component';



const routes: Routes = [
  {
    path: '', component: GuestComponent, children: [
      { path: 'reservations', component: ReservationsComponent},
      { path: 'guestProfil', component: ProfileComponent },
      { path: 'accommodation', component: AccommodationComponent},


    ]
  }
];


@NgModule({
  declarations: [
    GuestComponent,
    ReservationsComponent,
    ReserveAccommodationComponent
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
    MatFormFieldModule,
    MatSelectModule,
    MatNativeDateModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    RouterModule,
    RouterModule.forChild(routes),
    MatRadioModule,
    MatDatepickerModule,
    MatToolbarModule
  ],
  providers: [
    {provide: ErrorStateMatcher, useClass: ShowOnDirtyErrorStateMatcher}
  ]
})
export class GuestModule { }
