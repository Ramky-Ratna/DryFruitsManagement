import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../Entities/product';

@Injectable({
  providedIn: 'root'
})

export class DryfruitsService {

  private cloudUrl = 'https://dryfruitsmanagementapi.azurewebsites.net/api/';
  private baseUrl = "";
  constructor(private http: HttpClient) {
    this.baseUrl = this.cloudUrl;
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
