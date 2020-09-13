import { Component, OnInit } from '@angular/core';
import { DryfruitsService } from '../services/dryfruits.service';
import { Product } from '../Entities/product';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['home.component.css']
})
export class HomeComponent implements OnInit {

  public products: Product[];
  public productTypes = ['Almond', 'Anjeer', 'Apricot', 'Cashew', 'Dates', 'Kismis', 'Kiwi', 'Pista', 'Walnuts'];

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
