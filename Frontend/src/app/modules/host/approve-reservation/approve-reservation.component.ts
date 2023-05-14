import { Component, OnInit } from '@angular/core';
import { Reservation } from 'src/app/model/reservation.model'
import { ReservationService } from 'src/app/service/reservation.service';
import {Router} from "@angular/router";
import {FormControl, Validators} from "@angular/forms";
import { MatTableDataSource } from '@angular/material/table';
import { UserService } from 'src/app/service/user.service';

@Component({
  selector: 'app-approve-reservation',
  templateUrl: './approve-reservation.component.html',
  styleUrls: ['./approve-reservation.component.css']
})
export class ApproveReservationComponent implements OnInit {

  public dataSource = new MatTableDataSource<Reservation>();
  public displayedColumns = ['capacity' , 'startDate' , 'endDate' , 'numberOfCancelation', 'approve','disapprove' ];
  public id: any;
  constructor( private userService: UserService, private reservationService: ReservationService, private router: Router) { }


  ngOnInit(): void {
    this.id = this.userService.getCurrentUserId();
  
    this.loadHostReservations()
  }


  public loadHostReservations(){
      this.reservationService.getUndealetedHostUnreservedReservations(this.id).subscribe(res => {
      this.dataSource.data = res
    })
  }

  
  

  public approveReservation(reservation: Reservation) {    
      this.reservationService.approveReservation(reservation.id).subscribe(res => {
        this.loadHostReservations()
      });
      this.loadHostReservations()
      alert("Rezervacija je potvrdjena!")
  }

  public disapproveReservation(reservation: Reservation) {    
    this.reservationService.disapproveReservation(reservation.id).subscribe(res => {
      this.loadHostReservations()
    });
    this.loadHostReservations()
    alert("Rezervacija je odbijena!")
}
}
