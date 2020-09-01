import { Component } from '@angular/core';
import { DryfruitsService } from '../services/dryfruits.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['home.component.css']
})
export class HomeComponent {
  users: any;
  constructor(private dryFruitsService: DryfruitsService) {

  }

  ngOnInit(): void {
    this.dryFruitsService.getAllUsers().subscribe(
      data => {
        this.users = data;
      }
    );
  }

}
