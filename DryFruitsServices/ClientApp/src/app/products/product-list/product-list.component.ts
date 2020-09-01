import { Component, OnInit } from '@angular/core';
import { DryfruitsService } from '../../services/dryfruits.service';


@Component({
  selector: 'app-product-list-component',
  templateUrl: './product-list.component.html',
})

export class ProductListComponent implements OnInit {
  public products: any;

  ngOnInit() {
    this.loadAllProducts();
  }

  constructor(private dryfruitsService: DryfruitsService) {

  }

  public loadAllProducts() {
    this.dryfruitsService.getAllProducts().subscribe(
      data => {
        this.products = data;
      }
    );
  }

}

