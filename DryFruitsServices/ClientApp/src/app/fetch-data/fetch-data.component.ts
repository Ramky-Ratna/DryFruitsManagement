import { Component } from '@angular/core';
import { DryfruitsService } from '../services/dryfruits.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public users: any;
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

