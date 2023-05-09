import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Accommodation } from '../model/accommodation';

@Injectable({
  providedIn: 'root'
})
export class AccommodationService {

  apiHost: string = 'http://localhost:7066/';
  headers: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });

  constructor(private http: HttpClient) { }

  getAccommodations(): Observable<Accommodation[]> {
    return this.http.get<Accommodation[]>(this.apiHost + 'api/Accommodation', {headers: this.headers});
  }
  
  createAccommodation(accommodation: any): Observable<any> {
    return this.http.post<any>(this.apiHost + 'api/accommodation', accommodation, {headers: this.headers});
  }
  
  getAccommodation(id: string): Observable<Accommodation> {
    return this.http.get<Accommodation>(this.apiHost + 'api/accommodation/' + id, {headers: this.headers});
  }
  
  deleteAccommodation(id: any): Observable<any> {
    return this.http.delete<any>(this.apiHost + 'api/accommodation/' + id, {headers: this.headers});
  }

  updateAccommodation(accommodation: any): Observable<any> {
    return this.http.put<any>(this.apiHost + 'api/accommodation/' + accommodation.id, accommodation, {headers: this.headers});
  }

}
