import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { Accommodation } from 'src/app/model/accommodation';
import { Reservation } from 'src/app/model/reservation.model';
import { AccommodationService } from 'src/app/service/accommodation.service';
import { ReservationService } from 'src/app/service/reservation.service';

@Component({
  selector: 'app-change-price-accommodation',
  templateUrl: './change-price-accommodation.component.html',
  styleUrls: ['./change-price-accommodation.component.css']
})
export class ChangePriceAccommodationComponent implements OnInit {
  public accommodationCP: Accommodation = new Accommodation;

  constructor(public dialog: MatDialog, public accommodationService: AccommodationService, public reservationService: ReservationService, public router: Router) { }

  public reservationsAcc: Reservation[] = [];
  public accommodation: Accommodation = new Accommodation;

  public tomorrowDate : Date = new Date();
  public currentDate : Date = new Date();

  myFilter = (d: Date | null): boolean => {
    const day = (d || new Date()).getDay();
    // Return true za subotu i nedelju, false za sve ostale dane.
    return day === 6 || day === 0;
  }

  ngOnInit(): void {

    this.accommodation.startDate = this.accommodationCP.startDate
    this.accommodation.endDate = this.accommodationCP.endDate

   console.log(this.accommodationCP);
  }

  requiredStartDateControl = new FormControl('', [
    Validators.required,
  ]);

  
  requiredEndDateControl = new FormControl('', [
    Validators.required,
  ]);

  requiredCapacity = new FormControl('', [
    Validators.required,
  ]);
  
  public back() {
    this.dialog.closeAll();
  }

  public changeAccommodation(): void{
    if(this.isInputValid()){

      this.reservationService.getReservationsByAccommodationId(this.accommodationCP.id).subscribe(res => {

        let result = Object.values(JSON.parse(JSON.stringify(res)));
        result.forEach((element: any) => {
          var app = new Reservation(element);
            this.reservationsAcc.push(app);
        });

        let shouldBreak = false;
        this.reservationsAcc.forEach((element: any) => {        
          const date3 = new Date(element.startDate);
          const date4 = new Date(element.endDate);
        
          if (this.overlaps(date3, date4, this.accommodation.startDate, this.accommodation.endDate)) {          
            alert("Already exists reservations in this time !");
            shouldBreak = true;
          }
        });
        
        
        if (!shouldBreak) {

          this.accommodationService.updateAccommodation(this.accommodationCP).subscribe(res => {
            alert("Accommodation price has changed !");
            this.router.navigate(['/hostAccommodations']);
          });
        }

      });
        
    }else{
      this.messages()
    }
  
  }



  public messages(): void{
 
    if(this.accommodation.endDate ==  this.currentDate){
      alert("End date must be grater than tommorow !");
    }else if(this.accommodation.startDate > this.accommodation.endDate){
      alert("End date must be after start date !");
    }else if(this.accommodationCP.price <= 0){
      alert("Price must be positive number!")
    }
  }

  private isInputValid(): boolean {
    return this.accommodation.startDate >=  this.currentDate && this.accommodation.endDate >  this.currentDate && 
    this.accommodation.startDate < this.accommodation.endDate && this.accommodationCP.price > 0;

  }

  public overlaps(startDate1: Date, endDate1: Date, startDate2: Date, endDate2: Date): boolean {

    return startDate1 <= endDate2 && startDate2 <= endDate1;
  }

}
