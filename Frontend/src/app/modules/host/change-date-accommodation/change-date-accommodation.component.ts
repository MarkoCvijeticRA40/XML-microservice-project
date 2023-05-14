import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Accommodation } from 'src/app/model/accommodation';
import { Reservation } from 'src/app/model/reservation.model';
import { AccommodationService } from 'src/app/service/accommodation.service';
import { ReservationService } from 'src/app/service/reservation.service';

@Component({
  selector: 'app-change-date-accommodation',
  templateUrl: './change-date-accommodation.component.html',
  styleUrls: ['./change-date-accommodation.component.css']
})
export class ChangeDateAccommodationComponent implements OnInit {

  public accommodationCD: Accommodation = new Accommodation;
  public accommodation: Accommodation = new Accommodation;
  public reservationsAcc: Reservation[] = [];


  public tomorrowDate : Date = new Date();
  public currentDate : Date = new Date();

  public startDate : Date = new Date();
  public endDate : Date = new Date();
  public odgovor: boolean = false;


  constructor(private route: ActivatedRoute, public reservationService: ReservationService, public dialog: MatDialog, public accommodationService: AccommodationService, public router: Router) { }

  ngOnInit(): void {
   console.log(this.accommodationCD);
   this.accommodation = this.accommodationCD;

   this.route.params.subscribe((params: Params) => {
    this.accommodation = this.accommodationCD
    });

   this.currentDate = new Date()
   this.tomorrowDate.setDate(this.currentDate.getDate() + 1);
  }

  requiredStartDateControl = new FormControl('', [
    Validators.required,
  ]);

  
  requiredEndDateControl = new FormControl('', [
    Validators.required,
  ]);

  public back() {
    this.dialog.closeAll();
  }

  public changeAccommodation(): void{

    if(this.isInputValid()){

      this.reservationService.getReservationsByAccommodationId(this.accommodationCD.id).subscribe(res => {

        let result = Object.values(JSON.parse(JSON.stringify(res)));
        result.forEach((element: any) => {
          var app = new Reservation(element);
            this.reservationsAcc.push(app);
        });

        let shouldBreak = false;
        this.reservationsAcc.forEach((element: any) => {        
          const date3 = new Date(element.startDate);
          const date4 = new Date(element.endDate);
        
          if (this.overlaps(date3, date4, this.accommodationCD.startDate, this.accommodationCD.endDate)) {          
            alert("Already exists reservations in this time !");
            shouldBreak = true;
          }
        });
        
        
        if (!shouldBreak) {
          this.accommodationService.updateAccommodation(this.accommodationCD).subscribe(res => {
            alert("Accommodation availability has changed !");
            this.router.navigate(['/hostAccommodations']);
          });
        }

      });
        
    }else{
      this.messages()
    }
  
  }

  public messages(): void{
 
     if(this.accommodationCD.endDate ==  this.currentDate){
       alert("End date must be grater than tommorow !");
     }else if(this.accommodationCD.startDate > this.accommodationCD.endDate){
       alert("End date must be after start date !");
     }
   }

  private isInputValid(): boolean {
    return this.accommodationCD.startDate >=  this.currentDate && this.accommodationCD.endDate >  this.currentDate && this.accommodationCD.startDate < this.accommodationCD.endDate;

  }

  public overlaps(startDate1: Date, endDate1: Date, startDate2: Date, endDate2: Date): boolean {

    return startDate1 <= endDate2 && startDate2 <= endDate1;
  }

}
