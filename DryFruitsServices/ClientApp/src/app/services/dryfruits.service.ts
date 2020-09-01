import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../Entities/product';

@Injectable({
  providedIn: 'root'
})

export class DryfruitsService {

  private baseUrl = 'https://dryfruitsmanagementapi.azurewebsites.net/api/';

  constructor(private http: HttpClient) {

  }

  getAllProducts(): Observable<any> {
    return this.http.get(this.baseUrl+'Products');
  }

  getAllUsers(): Observable<any> {
    return this.http.get(this.baseUrl + 'User');
  }

  AddProduct(product: Object): Observable<Object> {
    return this.http.post(this.baseUrl + 'Products', JSON.stringify(product), {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    });
  }
}
