import { Component, OnInit } from '@angular/core';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { Reservation } from 'src/app/model/reservation.model'
import { ReservationService } from 'src/app/service/reservation.service';
import {Router} from "@angular/router";
import { UserService } from 'src/app/service/user.service';
import { ActivatedRoute, Params} from '@angular/router';
import {FormControl, Validators} from "@angular/forms";

@Component({
  selector: 'app-reserve-accommodation',
  templateUrl: './reserve-accommodation.component.html',
  styleUrls: ['./reserve-accommodation.component.css']
})
export class ReserveAccommodationComponent implements OnInit {

  constructor(private route: ActivatedRoute,private router: Router,private userService: UserService, private reservationService: ReservationService, public dialog: MatDialog) { }

  public accomodationId: any;
  public reservation: Reservation = new Reservation;
  public tomorrowDate : Date = new Date();
  public currentDate : Date = new Date();

  ngOnInit(): void {
         
        this.tomorrowDate.setDate(this.currentDate.getDate() + 1);
      //  this.reservation.guestId = this.userService.getCurrentUserId()
        this.route.params.subscribe((params: Params) => {
        this.reservation.accomodationId = this.accomodationId
        
    });
  }


  public reserveAccommodation(): void{
    
    this.reservationService.createReservation(this.reservation).subscribe(res => {
      alert(res)
    })
    /*
    this.reservationService.createReservation(this.reservation).subscribe(res => {
      alert(res)
    })*/
      /*
      if(this.isInputValid()){
        this.reservationService.createReservation(this.reservation).subscribe()
          
      }else{
        this.messages()
        
      }*/
      

  }


  public messages(): void{
    if(this.reservation.startDate.getDate ==  this.currentDate.getDate){
      alert("Start date must be grater than tommorow !");
    }else if(this.reservation.endDate.getDate ==  this.currentDate.getDate){
      alert("End date must be grater than tommorow !");
    }else if(this.reservation.capacity<1){
      alert("Number of people must be positive !");
    }else if(this.reservation.startDate.getDate > this.reservation.endDate.getDate){
      alert("End date must be after star date !");
    }
  }


  private isInputValid(): boolean {
    return this.reservation.startDate.getDate >  this.currentDate.getDate && this.reservation.endDate.getDate >  this.currentDate.getDate && this.reservation.capacity>1 && this.reservation.startDate.getDate < this.reservation.endDate.getDate;

  }

    
  


  requiredCapacity = new FormControl('', [
    Validators.required,
  ]);


  
  requiredStartDateControl = new FormControl('', [
    Validators.required,
  ]);

  
  requiredEndDateControl = new FormControl('', [
    Validators.required,
  ]);

  public back() {
    this.dialog.closeAll();
  }

}
