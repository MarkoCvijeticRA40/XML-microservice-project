import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Accommodation } from 'src/app/model/accommodation';
import { AccommodationService } from 'src/app/service/accommodation.service';

@Component({
  selector: 'app-create-accommodation',
  templateUrl: './create-accommodation.component.html',
  styleUrls: ['./create-accommodation.component.css']
})
export class CreateAccommodationComponent implements OnInit {

  facilities: string[] = ['Parking', 'Wi-Fi', 'Aircondition', 'Spa', 'Gym', 'Restaurant'];

  constructor(private accommodationService: AccommodationService, private router: Router) { }

  public accommodation: Accommodation = new Accommodation();
  public currentDate: Date = new Date();
  public tomorrowDate : Date = new Date();
  public currentDate1: Date = new Date();
  public tomorrowDate1 : Date = new Date();
  hour : number = 0 ;
  hour1 : number = 0 ;
  minute : number = 0;
  minute1 : number = 0;

  hours = [
    {value: 0, viewValue: '00'},
    {value: 1, viewValue: '1'},
    {value: 2, viewValue: '2'},
    {value: 3, viewValue: '3'},
    {value: 4, viewValue: '4'},
    {value: 5, viewValue: '5'},
    {value: 6, viewValue: '6'},
    {value: 7, viewValue: '7'},
    {value: 8, viewValue: '8'},
    {value: 9, viewValue: '9'},
    {value: 10, viewValue: '10'},
    {value: 11, viewValue: '11'},
    {value: 12, viewValue: '12'},
    {value: 13, viewValue: '13'},
    {value: 14, viewValue: '14'},
    {value: 15, viewValue: '15'},
    {value: 16, viewValue: '16'},
    {value: 17, viewValue: '17'},
    {value: 18, viewValue: '18'},
    {value: 19, viewValue: '19'},
    {value: 20, viewValue: '20'},
    {value: 21, viewValue: '21'},
    {value: 22, viewValue: '22'},
    {value: 23, viewValue: '23'},
    {value: 24, viewValue: '00'},
  ];


  minutes = [
    {value: 0, viewValue: '00'},
    {value: 10,   viewValue: '10'},
    {value: 15,  viewValue: '15'},
    {value: 20,   viewValue: '20'},
    {value: 25,   viewValue: '25'},
    {value: 30,  viewValue: '30'},
    {value: 35,   viewValue: '35'},
    {value: 40,   viewValue: '40'},
    {value: 45,   viewValue: '45'},
    {value: 50,   viewValue: '50'},
    {value: 60,   viewValue: '60'},
    {value: 60,  viewValue: '60'},

  ];

  createAccommodation(){
    this.setTime()

    console.log(this.accommodation.reservationType)    

    if(this.isInputValid()){
      this.accommodationService.createAccommodation(this.accommodation).subscribe(res => {
        alert("You have successfully created accommodation !");
      })
    }
  }


  public setTime() {
    this.accommodation.startDate.setHours(0);
    this.accommodation.startDate.setSeconds(0);
    this.accommodation.startDate.setMilliseconds(0);
    this.accommodation.startDate.setHours(this.hour);
    this.accommodation.startDate.setMinutes(this.minute);

    this.accommodation.endDate.setHours(0);
    this.accommodation.endDate.setSeconds(0);
    this.accommodation.endDate.setMilliseconds(0);
    this.accommodation.endDate.setHours(this.hour);
    this.accommodation.endDate.setMinutes(this.minute);
  }
  private isInputValid(): boolean {

    if(this.accommodation.name == ''  &&  this.accommodation.location == '' &&  this.accommodation.minCapacity  <= 0 
    &&  this.accommodation.maxCapacity  <= 0  && this.accommodation.price  <= 0 ){
      alert("You must fill in all fields!")
      return false;
    }
    if(this.accommodation.minCapacity >= this.accommodation.maxCapacity){
      alert("Min Capacity must be less than the Max Capacity!")
      return false;
    }
    if(this.accommodation.endDate <= this.accommodation.startDate){
      alert("Start Date must be less than the End Date!")
      return false;
    }

    return true;
  }

  requiredNameControl = new FormControl('', [
    Validators.required,
  ]);

  requiredLocationControl = new FormControl('', [
    Validators.required,
  ]);

  requiredMinCapacity = new FormControl('', [
    Validators.required,
  ]);

  requiredMaxCapacity = new FormControl('', [
    Validators.required,
  ]);

  requiredStartDateControl = new FormControl('', [
    Validators.required,
  ]);

  requiredEndDateControl = new FormControl('', [
    Validators.required,
  ]);

  requiredPrice = new FormControl('', [
    Validators.required,
  ]);


  ngOnInit(): void {
    
    this.tomorrowDate.setDate(this.currentDate.getDate() + 1);
    this.tomorrowDate1.setDate(this.currentDate1.getDate() + 1);

  }

  public onFileSelected(event: Event): void {
    const input = event.target as HTMLInputElement;
    const file: File | undefined = input.files?.[0];
    if (file) {
      const reader: FileReader = new FileReader();
      reader.readAsDataURL(file);
      reader.onload = () => {
        const base64Img: string = reader.result as string;
        this.accommodation.photos.push(base64Img);
      };
    }
  }

}
