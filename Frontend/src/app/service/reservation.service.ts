import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Reservation } from '../model/reservation.model';




@Injectable({
  providedIn: 'root'
})
export class ReservationService {

  apiHost: string = 'http://localhost:16179/api/reservation';
  headers: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });

  constructor(private http: HttpClient) { }


  getReservations(): Observable<Reservation[]> {
    return this.http.get<Reservation[]>(this.apiHost, {headers: this.headers});
  }

  getGuestReservations(id: any): Observable<Reservation[]> {
    return this.http.get<Reservation[]>(this.apiHost+ '/undealeted/guest/' + id, {headers: this.headers});
  }

  getUndealetedGuestReservedReservations(id: any): Observable<Reservation[]> {
    return this.http.get<Reservation[]>(this.apiHost+ '/guest/' + id, {headers: this.headers});
  }


  cancelReservation(id: any): Observable<any> {
    return this.http.delete<any>(this.apiHost + '/cancel/' + id, {headers: this.headers});
  }

  approveReservation(id: any): Observable<any> {
    return this.http.put<any>(this.apiHost + '/approve/' + id, {headers: this.headers});
  }


  disapproveReservation(id: any): Observable<any> {
    return this.http.put<any>(this.apiHost + '/disapprove/' + id, {headers: this.headers});
  }

  createReservation(reservation: any): Observable<any> {
    return this.http.post(this.apiHost , reservation , { responseType: 'text' });
  }

  

}
