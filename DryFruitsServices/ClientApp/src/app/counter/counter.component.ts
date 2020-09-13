import { Component, OnInit } from '@angular/core';
import { Product } from '../Entities/product';
import { DryfruitsService } from '../services/dryfruits.service';


@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html',
  styleUrls: ['counter.component.css']
})
export class CounterComponent implements OnInit {
  public products: any;
  public product: Product = new Product();
  public showModal: boolean;
  public showUpdateModal: boolean;
  public productId: number;
  public productType = ['Almond', 'Anjeer', 'Apricot', 'Cashew', 'Dates', 'Kismis', 'Kiwi', 'Pista', 'Walnuts'];

  ngOnInit() {
    this.loadAllProducts();
  }

  constructor(private dryfruitsService:DryfruitsService) {

  }

  public loadAllProducts() {
    this.dryfruitsService.getAllProducts().subscribe(
      data => {
        this.products = data;        
      }
    );
  }

  public addProduct() {    
    this.dryfruitsService.AddProduct(this.product).subscribe(
      data => {
        this.loadAllProducts();
        location.reload();
      }
    );
  }

  public updateProduct(productid: number) {
    this.dryfruitsService.UpdateProduct(productid,this.product).subscribe(
      data => {
        this.loadAllProducts();
        location.reload();
      }
    );
  }

  public DeleteProduct(productid: number) {
        this.dryfruitsService.DeleteProduct(productid).subscribe(
        data => {
          this.loadAllProducts();
          this.hide()
          //location.reload();
        }
      );
  }

 //Bootstrap Modal Open event
 public show(productid:number) {
   this.showModal = true; // Show-Hide Modal Check
   this.productId = productid;
  }
  //Bootstrap Modal Close event
  public hide() {
    this.showModal = false;
  }

  //Bootstrap Modal Open event
  public showupdatemodal(product: any) {
    this.showUpdateModal = true; // Show-Hide Modal Check
    this.product = product;
  }
  //Bootstrap Modal Close event
  public hideupdatemodal() {
    this.showUpdateModal = false;
  }
}
