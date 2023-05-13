import { Component, OnInit } from '@angular/core';
import { Reservation } from 'src/app/model/reservation.model'
import { ReservationService } from 'src/app/service/reservation.service';
import {Router} from "@angular/router";
import {FormControl, Validators} from "@angular/forms";
import { MatTableDataSource } from '@angular/material/table';
import { UserService } from 'src/app/service/user.service';

@Component({
  selector: 'app-reservations',
  templateUrl: './reservations.component.html',
  styleUrls: ['./reservations.component.css']
})
export class ReservationsComponent implements OnInit {

  public dataSource = new MatTableDataSource<Reservation>();
  public displayedColumns = ['capacity' , 'startDate' , 'endDate' , 'delete'];
  public id: any;

  constructor( private userService: UserService, private reservationService: ReservationService, private router: Router) { }


  ngOnInit(): void {
    this.id = this.userService.getCurrentUserId();
    
    this.loadGuestReservations()
  }


  public loadGuestReservations(){
      this.reservationService.getUndealetedGuestReservedReservations(this.id).subscribe(res => {
      this.dataSource.data = res
    })
  }

  

  public deleteReservation(reservation: Reservation) {    
      this.reservationService.cancelReservation(reservation.id).subscribe(res => {
        this.loadGuestReservations();
      });
      alert("Rezervacija je otkazana !")
  }
  

}
