import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { Accommodation } from 'src/app/model/accommodation';
import { AccommodationService } from 'src/app/service/accommodation.service';
import { UserService } from 'src/app/service/user.service';

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

  constructor(private userService: UserService, private accommodationService: AccommodationService, private router: Router) { }

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

        this.accommodations = this.searchedAccommodations;
        console.log(this.searchedAccommodations);
  
      })
    }
    else {
      alert("You must fill in all fields!");
    }
  }   


}
