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

  public displayedColumns = ['name' , 'location' , 'facilities' , 'photos' , 'minCapacity' , 'maxCapacity' , 'startDate', 'endDate',
'price'];

  constructor(private accommodationService: AccommodationService, private router: Router) { }

  ngOnInit(): void {
    this.loadAccommodations()
  }

  public loadAccommodations(){
    this.accommodationService.getAccommodations().subscribe(res => {
      alert(1);
      this.dataSource.data = res
      this.accommodations = res
    })

  }

  public addAccommodation() {
    this.router.navigate(['/createAccommodation']);
  }

}
