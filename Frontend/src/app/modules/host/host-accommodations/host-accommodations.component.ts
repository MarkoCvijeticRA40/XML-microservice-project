import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { Accommodation } from 'src/app/model/accommodation';
import { AccommodationService } from 'src/app/service/accommodation.service';
import { UserService } from 'src/app/service/user.service';
import { ChangeDateAccommodationComponent } from '../change-date-accommodation/change-date-accommodation.component';
import { ChangePriceAccommodationComponent } from '../change-price-accommodation/change-price-accommodation.component';
import { ReservationService } from 'src/app/service/reservation.service';
import { Reservation } from 'src/app/model/reservation.model';

@Component({
  selector: 'app-host-accommodations',
  templateUrl: './host-accommodations.component.html',
  styleUrls: ['./host-accommodations.component.css']
})
export class HostAccommodationsComponent implements OnInit {

  public accommodations: Accommodation[] = [];
  location : string = '';
  guests: number = 0;
  startDate: Date = new Date();
  endDate: Date = new Date();
  public id: any;

  searchedAccommodations: Accommodation[] = [];
  searchPerformed = false;
  odgovor: boolean = false;
  zbir: number=0;

  constructor(private userService: UserService, public reservationService: ReservationService, public dialog: MatDialog, private accommodationService: AccommodationService, private router: Router) { }

  ngOnInit(): void {
    this.id = this.userService.getCurrentUserId();

    this.loadAccommodations()
  }

  public loadAccommodations(){
    this.accommodationService.getAccommodations().subscribe(res => {
      let result = Object.values(JSON.parse(JSON.stringify(res)));

      result.forEach((element: any) => {
        var app = new Accommodation(element);
        if(app.hostId == this.id){
          this.accommodations.push(app);
        }
      });

    })

  }

  public addAccommodation() {
    this.router.navigate(['/createAccommodation']);
  }

  private isInputValid(): boolean {
    return this.location != ''  &&  this.guests  > 0;
  }

  onSearch() {
  
    if(this.isInputValid())
    {
    
      this.searchedAccommodations = [];
      this.searchPerformed = true;
  
      this.accommodationService.getAllAccommodationsBySearch(this.location, this.guests,this.startDate, this.endDate).subscribe(res => {
        let result = Object.values(JSON.parse(JSON.stringify(res)));
        result.forEach((element: any) => {
          var app = new Accommodation(element);
          this.searchedAccommodations.push(app);
        });


        this.searchedAccommodations.forEach((element: any) => {
          var app = new Accommodation(element);
  
          this.reservationService.getAllResByAccId(element.id).subscribe(res => {
    
                let result = Object.values(JSON.parse(JSON.stringify(res)));
                result.forEach((element1: any) => {
                  var app1 = new Reservation(element1);
                  app1.capacity = element1.capacity

                  const date4 = new Date(element1.startDate);
                  const date5 = new Date(element1.endDate);
    
                  this.odgovor = this.overlaps(element1.startDate, element1.endDate, this.startDate, this.endDate);
                  this.zbir = this.guests + app1.capacity

                    if (this.odgovor && this.zbir > app.maxCapacity) {          
    
                      this.searchedAccommodations.pop();
                    }
                    else if (this.zbir < app.minCapacity){
                      alert("Not enough guests");
                    }

                    //this.accommodations = this.searchedAccommodations;

                });
               });
               this.accommodations = this.searchedAccommodations;

          })

          })

    }
    else {
      alert("You must fill in all fields!");
    }
    
  }   

  public overlaps(startDate1: Date, endDate1: Date, startDate2: Date, endDate2: Date): boolean {

    return startDate1 <= endDate2 && startDate2 <= endDate1;
  }

  public changeDate(accommodation: Accommodation) {

    const dialogConfig = new MatDialogConfig();

    dialogConfig.id = "modal-component";
    dialogConfig.height = "auto";
    dialogConfig.width = "600px";
    dialogConfig.disableClose = true;

    const modalDialog = this.dialog.open(ChangeDateAccommodationComponent, dialogConfig);
    modalDialog.disableClose =true
    modalDialog.componentInstance.accommodationCD = accommodation;

  }

  changePrice(accommodation: Accommodation){
    const dialogConfig = new MatDialogConfig();

    dialogConfig.id = "modal-component";
    dialogConfig.height = "auto";
    dialogConfig.width = "600px";
    dialogConfig.disableClose = true;

    const modalDialog = this.dialog.open(ChangePriceAccommodationComponent, dialogConfig);
    modalDialog.disableClose =true
    modalDialog.componentInstance.accommodationCP = accommodation;
  }

}
