import { Reservation } from "./reservation";

export class Accommodation {

    id: string = "";
    name : string = '';
    location : string = '';
    facilities: string[] = [];
    photos: string[] = [];
    minCapacity: number = 0;
    maxCapacity: number = 0;
    startDate: Date = new Date();
    endDate: Date = new Date();
    price: number = 0;
    reservationType: Reservation = Reservation.Autoautomatically;
    grade: number = 0;
  
    constructor(obj?: any) {
      if (obj) {
        this.id = obj.id;
        this.name = obj.name;
        this.location = obj.location;
        this.facilities = obj.facilities;
        this.photos = obj.photos;
        this.minCapacity = obj.minCapacity;
        this.maxCapacity = obj.maxCapacity;
        this.startDate = obj.startDate;
        this.endDate = obj.endDate;
        this.price = obj.price;
        this.reservationType = obj.reservationType;
        this.grade = obj.grade;
      }
    }
  }
  