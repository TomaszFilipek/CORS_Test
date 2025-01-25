import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = 'http://localhost:5000/'; //'https://testcors.bieda.it';

  constructor(private http: HttpClient) {}

  // Metoda do pobierania danych
  getData(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
