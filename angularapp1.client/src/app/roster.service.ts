import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RosterService {
  baseUrl: string = "https://localhost:7204/api";
  constructor(private http: HttpClient) { }

  public getRoster(): Observable<any> {
    return this.http.get(`${this.baseUrl}/RosterEntry`);
  }

  public getEntryById(id: number): Observable<any> {
    return this.http.get(`${this.baseUrl}/RosterEntry/${id}`);
  }

  public updateEntry(id: number, entry: any): Observable<any> {
    return this.http.put(`${this.baseUrl}/RosterEntry/${id}`, entry);
  }
}
