import { Component, OnInit } from '@angular/core';
import { HttpService } from '../Service/http.service';
import { House, Sensor } from '../all-houses/all-houses.component';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-sensors',
  templateUrl: './sensors.component.html',
  styleUrls: ['./sensors.component.css']
})
export class SensorsComponent implements OnInit {
  allSensors$: Observable<Array<Sensor>>

  constructor(private httpService: HttpService) { }

  ngOnInit() {
    this.allSensors$=this.httpService.getSensors()

    }

}


