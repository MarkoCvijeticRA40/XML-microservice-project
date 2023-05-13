export class Reservation {

    id: string = "";
    capacity: number = 0;
    startDate: Date = new Date();
    endDate: Date = new Date();
    accommodationId: string = "";
    approved : boolean = false;
    deleted : boolean = false;
    numberOfCancelation: number = 0; 


    

    constructor(obj?: any) {
      if (obj) {
        this.id = obj.id;
        this.capacity = obj.minCapacity;
        this.startDate = obj.startDate;
        this.endDate = obj.endDate;
        this.accommodationId = obj.accommodationId;
        this.deleted = obj.pendingApproval;
        this.approved = obj.approved;
        this.numberOfCancelation = obj.numberOfCancelation;
      }
    }


}
