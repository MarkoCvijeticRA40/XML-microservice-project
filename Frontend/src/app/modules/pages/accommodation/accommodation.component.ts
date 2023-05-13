import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { Accommodation } from 'src/app/model/accommodation';
import { AccommodationService } from 'src/app/service/accommodation.service';

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

  searchedAccommodations: Accommodation[] = [];
  searchPerformed = false;

  constructor(private accommodationService: AccommodationService, private router: Router) { }

  ngOnInit(): void {
    this.loadAccommodations()
  }

  public loadAccommodations(){
    this.accommodationService.getAccommodations().subscribe(res => {
      this.dataSource.data = res
      this.accommodations = res
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
