import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../Entities/product';

@Injectable({
  providedIn: 'root'
})

export class DryfruitsService {
  private localurl = 'https://localhost:44377/api/';
  private cloudUrl = 'https://dryfruitsmanagementapi.azurewebsites.net/api/';
  private baseUrl = "";
  constructor(private http: HttpClient) {
    this.baseUrl = this.localurl;
  }

  getAllProducts(): Observable<any> {
    return this.http.get(this.baseUrl+'Products');
  }

  getProductById(id:any): Observable<any> {
    return this.http.get(this.baseUrl + 'Products/'+id);
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

  UpdateProduct(productid: number, product: Product): Observable<{}> {
    return this.http.put(this.baseUrl + 'Products/' + productid, JSON.stringify(product), {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    });
  }

  DeleteProduct(productid: number): Observable<{}> {
    return this.http.delete(this.baseUrl + 'Products/' + productid);
  }
}
