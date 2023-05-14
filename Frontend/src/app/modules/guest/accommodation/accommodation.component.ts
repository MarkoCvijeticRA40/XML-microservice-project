import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { Accommodation } from 'src/app/model/accommodation';
import { AccommodationService } from 'src/app/service/accommodation.service';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { ReserveAccommodationComponent } from '../reserve-accommodation/reserve-accommodation.component';
import { ReservationService } from 'src/app/service/reservation.service';
import { Reservation } from 'src/app/model/reservation.model';

@Component({
  selector: 'app-accommodation',
  templateUrl: './accommodation.component.html',
  styleUrls: ['./accommodation.component.css']
})
export class AccommodationComponent implements OnInit {

  public dataSource = new MatTableDataSource<Accommodation>();
  public accommodations: Accommodation[] = [];

  location : string = '';
  guests: number = 0;
  startDate: Date = new Date();
  endDate: Date = new Date();
  odgovor: boolean = false;
  zbir: number=0;

  searchedAccommodations: Accommodation[] = [];
  searchPerformed = false;

  constructor(private accommodationService: AccommodationService, public reservationService: ReservationService, private router: Router, public dialog: MatDialog) { }

  

  ngOnInit(): void {
    
    this.dialog.afterAllClosed.subscribe(
      data => this.loadAccommodations()
    );  
    this.loadAccommodations()
  }

  public loadAccommodations(){
    this.accommodationService.getAccommodations().subscribe(res => {
      this.dataSource.data = res
      this.accommodations = res
    })

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


  reserve(accommodation: Accommodation){
    const dialogConfig = new MatDialogConfig();
    

    dialogConfig.id = "modal-component";
    dialogConfig.height = "auto";
    dialogConfig.width = "600px";
    dialogConfig.disableClose = true;

    const modalDialog = this.dialog.open(ReserveAccommodationComponent, dialogConfig);
    modalDialog.disableClose =true
    modalDialog.componentInstance.accomodationId = accommodation.id;

  }

  public overlaps(startDate1: Date, endDate1: Date, startDate2: Date, endDate2: Date): boolean {

    return startDate1 <= endDate2 && startDate2 <= endDate1;
  }
}
