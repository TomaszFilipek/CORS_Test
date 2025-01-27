import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiBaseUrl = 'https://xxtestapi.toadres.pl/api'; //'https://testcors.bieda.it';
  private readonly apiUrl = `${this.apiBaseUrl}/Home`;

  constructor(private http: HttpClient) {}

  // Metoda do pobierania danych
  getData(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
