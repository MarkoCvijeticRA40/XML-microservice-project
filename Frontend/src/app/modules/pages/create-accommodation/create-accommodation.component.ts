import { Component, OnInit } from '@angular/core';
import { AccommodationService } from 'src/app/service/accommodation.service';
import {Router} from "@angular/router";
import { Accommodation } from 'src/app/model/accommodation';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-create-accommodation',
  templateUrl: './create-accommodation.component.html',
  styleUrls: ['./create-accommodation.component.css']
})
export class CreateAccommodationComponent implements OnInit {

  public dataSource = new MatTableDataSource<Accommodation>();
  public displayedColumns = ['name' , 'location' , 'facilities' , 'photos' , 'minCapacity' , 'maxCapacity' , 'startDate', 'endDate',
'price'];

  constructor(private accommodationService: AccommodationService, private router: Router) { }

  ngOnInit(): void {
    this.loadAccommodations()
  }

  public loadAccommodations(){
    this.accommodationService.getAccommodations().subscribe(res => {
      this.dataSource.data = res
    })

  }

}
