import { Component, OnInit } from '@angular/core';
import { HttpService } from '../Service/http.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-all-houses',
  templateUrl: './all-houses.component.html',
  styleUrls: ['./all-houses.component.css']
})
export class AllHousesComponent implements OnInit{



  constructor(private httpService: HttpService) { }
  allHouses$: Observable<Array<House>>
  
    ngOnInit(): void {
      this.allHouses$ = this.httpService.getHouses()
    }
  }



  

export interface House{
  houseId?: number;
  description?: string;
  sensors?: Sensor[];
  
}
export interface Sensor{
  temperature?: number;
  humidity?: number;
  smoke?: number;
  isMove?: number;
  sensorId?: number;
  isOn?: boolean;
  houseId?: number;
  house?: House[];
}
