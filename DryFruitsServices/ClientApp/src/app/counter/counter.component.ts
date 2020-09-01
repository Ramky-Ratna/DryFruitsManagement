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
}

