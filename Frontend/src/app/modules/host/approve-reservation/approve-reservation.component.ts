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
  public displayedColumns = ['capacity' , 'startDate' , 'endDate' , 'numberOfCancelation', 'delete' ];
  
  constructor( private userService: UserService, private reservationService: ReservationService, private router: Router) { }


  ngOnInit(): void {
    
    this.loadHostReservations()
  }


  public loadHostReservations(){
      this.reservationService.getReservations().subscribe(res => {
      this.dataSource.data = res
    })
  }

  

  public approveReservation(reservation: Reservation) {    
      this.reservationService.approveReservation(reservation.id).subscribe(res => {
        this.loadHostReservations
      });
      alert("Rezervacija je potvrdjena!")
  }
}
