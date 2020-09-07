import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'; 
import { DryfruitsService } from '../../services/dryfruits.service';

@Component({
  selector: 'app-product-details',
  templateUrl: 'product-details.component.html',
  styleUrls: ['product-details.component.css']
})

export class ProductDetailsComponent implements OnInit {
  public id: number;
  public product: any;
  constructor(private route: ActivatedRoute, private dryfruitsService: DryfruitsService) {

  }

  ngOnInit() {
    this.id = this.route.snapshot.params['id'];
    this.loadAllProductsById(this.id);
  }

  public loadAllProductsById(productid: any) {
    this.dryfruitsService.getProductById(productid).subscribe(
      data => {
        this.product = data;
      }
    );
  }
}
