export class Reservation {

    id: string = "";
    capacity: number = 0;
    startDate: Date = new Date();
    endDate: Date = new Date();
    accomodationId: string = "";
    approved : boolean = false;
    deleted : boolean = false;
    numberOfCancelation: number = 0; 
    guestId : string= ""


    

    constructor(obj?: any) {
      if (obj) {
        this.id = obj.id;
        this.guestId = obj.guestId;
        this.capacity = obj.minCapacity;
        this.startDate = obj.startDate;
        this.endDate = obj.endDate;
        this.accomodationId = obj.accommodationId;
        this.deleted = obj.pendingApproval;
        this.approved = obj.approved;
        this.numberOfCancelation = obj.numberOfCancelation;
      }
    }


}
